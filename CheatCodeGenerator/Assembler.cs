using Keystone;

using System.Collections.Generic;
using System.Text;

namespace CheatCodeGenerator
{
    public static class Assembler
    {
        /// <summary>
        /// 计算跳转偏移
        /// </summary>
        /// <param name="injectAddr">注入地址</param>
        /// <param name="destAddr">目的地址</param>
        /// <returns>跳转偏移量</returns>
        public static int CalcHexOffset(uint injectAddr, uint destAddr)
        {
            if (destAddr >= injectAddr)     //判断地址大小
            {
                return (int)(destAddr - (injectAddr + 8)) / 4;                  //原码
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

            lines.Add($"0x{injectAddr:X}:");
            var asm = useLink ? "BL" : "B";
            lines.Add($"{asm} #0x{offset:X8}\r\n");

            if (asmCode == null || asmCode.Length <= 0)
            {
                lines.Add($"0x{destAddr:X}:");
                lines.Add("//此处写代码");
            }
            else
            {
                lines.AddRange(asmCode);
            }

            if (jumpBack)
            {
                asm = useLink ? "BX LR" : $"B #0x{(int)(-offset - 4):X8}";
                lines.Add(asm);
            }

            return lines.ToArray();
        }

        /// <summary>
        /// 汇编转hex
        /// </summary>
        /// <param name="asmCode">汇编代码</param>
        /// <param name="addZeroX">开头是否添加0x</param>
        /// <returns></returns>
        public static string[] Assembler2Hex(string[] asmCode, bool addZeroX = false)
        {
            var hexList = new List<string>();

            using (var keystone = new Engine(Architecture.ARM, Mode.LITTLE_ENDIAN)
            {
                ThrowOnError = true
            })
            {
                foreach (var line in asmCode)
                {
                    var encodeData = keystone.Assemble(line, 0);
                    hexList.AddRange(encodeData.ToHex(addZeroX ? "0x" : ""));
                }
            }
            return hexList.ToArray();
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
            var hexList = Assembler2Hex(asmCode);

            var codeLines = new List<string>
            {
                //设定偏移量
                "D3000000",
                baseAddr.ToString("X8"),

                //目的地址代码长度
                $"E0{destAddr - baseAddr:X6}",
                ((hexList.Length - 1) * 4).ToString("X8")
            };
            //写入汇编
            if (hexList.Length > 1)
            {
                for (int i = 1; i < hexList.Length; i++)
                {
                    codeLines.Add(hexList[i]);
                }
            }
            if (codeLines.Count % 2 != 0) codeLines.Add("00000000");

            //注入点跳转
            codeLines.Add((injectAddr - baseAddr).ToString("X8"));
            codeLines.Add(hexList[0]);

            
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