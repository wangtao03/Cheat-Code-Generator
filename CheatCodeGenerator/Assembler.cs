using Keystone;

using System;
using System.Collections.Generic;
using System.Text;

namespace CheatCodeGenerator
{
    public static class Assembler
    {
        /// <summary>
        /// 单行ARM汇编转字节数组
        /// </summary>
        /// <param name="line">汇编代码</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>字节数组</returns>
        public static byte[] ToBytes(string line, bool little_endiam = true)
        {
            using (var keystone = new Engine(Architecture.ARM, little_endiam ? Mode.LITTLE_ENDIAN : Mode.BIG_ENDIAN)
            {
                ThrowOnError = true
            })
            {
                var encodeData = keystone.Assemble(line, 0);
                return encodeData.Buffer;
            }
        }

        /// <summary>
        /// 多行ARM汇编转数组
        /// </summary>
        /// <param name="lines">汇编代码数组</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>字节数组</returns>
        public static byte[] ToBytes(string[] lines, bool little_endiam = true) => ToBytes(string.Join(";", lines), little_endiam);

        /// <summary>
        /// 单行ARM汇编转32位无符号整数
        /// </summary>
        /// <param name="line">汇编代码</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>无符号32位整数</returns>
        public static uint ToUInt32(string line, bool little_endiam = true) => BitConverter.ToUInt32(ToBytes(line, little_endiam), 0);

        /// <summary>
        /// 单行ARM汇编转32位有符号整数
        /// </summary>
        /// <param name="line">汇编代码</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>32位有符号整数</returns>
        public static int ToInt32(string line, bool little_endiam = true) => BitConverter.ToInt32(ToBytes(line, little_endiam), 0);

        /// <summary>
        /// 单行ARM汇编转16进制文本
        /// </summary>
        /// <param name="line">汇编代码</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>16进制文本</returns>
        public static string ToHex(string line, bool little_endiam = false) => ToInt32(line, little_endiam).ToString("X8");

        /// <summary>
        /// 多行ARM汇编转32位无符号整数数组
        /// </summary>
        /// <param name="lines">汇编代码数组</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>32位无符号整数数组</returns>
        public static uint[] ToUInt32(string[] lines, bool little_endiam = true)
        {
            var list = new List<uint>();
            var asmBytes = ToBytes(lines, little_endiam);

            if (asmBytes.Length % 4 == 0)
            {
                for (int i = 0; i < asmBytes.Length; i += 4)
                {
                    list.Add(BitConverter.ToUInt32(asmBytes, i));
                }
            }
            return list.ToArray();
        }

        /// <summary>
        /// 多行ARM汇编转32位有符号整数数组
        /// </summary>
        /// <param name="lines">汇编代码数组</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>32位有符号整数数组</returns>
        public static int[] ToInt32(string[] lines, bool little_endiam = true)
        {
            var list = new List<int>();
            var asmBytes = ToBytes(lines, little_endiam);

            if (asmBytes.Length % 4 == 0)
            {
                for (int i = 0; i < asmBytes.Length; i += 4)
                {
                    list.Add(BitConverter.ToInt32(asmBytes, i));
                }
            }
            return list.ToArray();
        }

        /// <summary>
        /// 多行ARM汇编转16进制文本数组
        /// </summary>
        /// <param name="lines">汇编代码</param>
        /// <param name="little_endiam">是否为小端序</param>
        /// <returns>16进制文本数组</returns>
        public static string[] ToHex(string[] lines, bool little_endiam = true)
        {
            var list = new List<string>();
            var uintArray = ToInt32(lines, little_endiam);
            foreach (var i in uintArray)
            {
                list.Add(i.ToString("X8"));
            }
            return list.ToArray();
        }

        /// <summary>
        /// 计算跳转偏移
        /// </summary>
        /// <param name="injectAddr">注入地址</param>
        /// <param name="destAddr">目的地址</param>
        /// <returns>跳转偏移量</returns>
        public static int CalcOffset(uint injectAddr, uint destAddr)
        {
            if (destAddr >= injectAddr)     //判断地址大小
            {
                return (int)(destAddr - (injectAddr + 8)) / 4;                  //源码
            }
            else
            {
                return 0x00FFFFFF - (int)((injectAddr + 8) - destAddr) / 4;     //补码
            }
        }

        /// <summary>
        /// 生成用于注入的汇编代码
        /// </summary>
        /// <param name="injectAddr">注入地址</param>
        /// <param name="destAddr">目的地址</param>
        /// <param name="asmCode">汇编代码</param>
        /// <param name="useLink">是否使用带链接的跳转</param>
        /// <param name="jumpBack">是否跳回到注入点</param>
        /// <returns>汇编代码</returns>
        public static string[] AssemblerGenerator(uint injectAddr, uint destAddr, string[] asmCode, bool useLink = false, bool jumpBack = true)
        {
            var lines = new List<string>();
            var offset = destAddr - injectAddr;

            var asm = useLink ? "BL" : "B";
            lines.Add($"{asm} #0x{offset:X6}");

            if (asmCode == null || asmCode.Length <= 0)
            {
                lines.Add("//此处写代码");
            }
            else
            {
                lines.AddRange(asmCode);
            }

            if (jumpBack)
            {
                asm = useLink ? "MOV PC, LR" : $"B #0x{(uint)-offset:X6}";
                lines.Add(asm);
            }

            return lines.ToArray();
        }

        /// <summary>
        /// 生成作弊代码
        /// </summary>
        /// <param name="baseAddr">基础地址</param>
        /// <param name="injectAddr">注入地址</param>
        /// <param name="destAddr">目的地址</param>
        /// <param name="asmCode">汇编代码</param>
        /// <param name="useLink">是否使用带链接的跳转</param>
        /// <returns>作弊代码</returns>
        public static string CheatCodeGenerator(uint baseAddr, uint injectAddr, uint destAddr, string[] asmCode, bool useLink = true, bool jumpBack = true)
        {
            //var asmLines = AssemblerGenerator(injectAddr, destAddr, asmCode, useLink, jumpBack);
            var hexLines = ToHex(asmCode);

            var codeLines = new List<string>
            {
                //设定偏移量
                "D3000000",
                baseAddr.ToString("X8"),
                //设定注入地址
                (injectAddr - baseAddr).ToString("X8"),
                hexLines[0],
                //为目的地址申请控件
                $"E0{destAddr - baseAddr:X6}",
                ((hexLines.Length - 1) * 4).ToString("X8")
            };
            //写入汇编
            if (hexLines.Length > 1)
            {
                for (int i = 1; i < hexLines.Length; i++)
                {
                    codeLines.Add(hexLines[i]);
                }
            }
            if (codeLines.Count % 2 != 0) codeLines.Add("00000000");
            //添加结束
            codeLines.Add("D2000000");
            codeLines.Add("00000000");

            var stringBuilder = new StringBuilder();
            for (int i = 0; i < codeLines.Count; i += 2)
            {
                stringBuilder.AppendLine($"{codeLines[i]} {codeLines[i + 1]}");
            }
            return stringBuilder.ToString();
        }
    }
}