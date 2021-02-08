using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheatCodeGenerator
{
    /// <summary>
    /// 作弊码解析类
    /// </summary>
    public abstract class CheatCode
    {
        /// <summary>
        /// 解释作弊码
        /// </summary>
        /// <param name="code">作弊码/param>
        /// <returns>解释</returns>
        public abstract string Interpreter(string code, ref int offset);

        /// <summary>
        /// 检查作弊码格式
        /// </summary>
        /// <param name="code">作弊码</param>
        /// <returns>匹配结果</returns>
        public virtual Match CheckFormat(string code)
        {
            var regex = new Regex(@"\b(([\dA-E])([\dA-F])([\dA-F]{6}))\s+?(([\dA-F]{4})([\dA-F]{4}))\b", RegexOptions.IgnoreCase);
            if (!regex.IsMatch(code)) throw new CheatCodeFormatException();

            return regex.Match(code);
        }

        /// <summary>
        /// 检查作弊码格式
        /// </summary>
        /// <param name="code">作弊码</param>
        /// <returns>匹配结果</returns>
        public virtual Match CheckFormat(Regex regex, string code)
        {
            if (!regex.IsMatch(code)) throw new CheatCodeFormatException();

            return regex.Match(code);
        }

        /// <summary>
        /// 作弊代码格式异常类
        /// </summary>
        public class CheatCodeFormatException : FormatException
        {
            public CheatCodeFormatException() : base("作弊代码格式异常!")
            {
            }


            public CheatCodeFormatException(string message) : base(message)
            {
            }


            public CheatCodeFormatException(string message, Exception innerException) : base(message, innerException)
            {

            }
        }
    }

    /// <summary>
    /// 内存写入码解析类
    /// </summary>
    public class CheatMemoryWrites : CheatCode
    {
        public override string Interpreter(string code, ref int offset)
        {
            try
            {
                var regex = new Regex(@"\b([0-2])([\dA-F]{7})\s+?([\dA-F]{8})\b");
                var mathc = CheckFormat(regex,code);

                var type = Convert.ToUInt32(mathc.Groups[1].Value,16);
                var addr = Convert.ToInt32(mathc.Groups[2].Value,16);
                var value = Convert.ToInt32(mathc.Groups[3].Value,16);

                var mask = new uint[3] { 0XFFFFFFFF, 0x0000FFFF, 0x000000FF };
                var bit = new string[3] { "单字节", "双字节", "四字节" };

                return $"向 0x{addr+offset:X} 写 0x{(mask[type] & value):X8} ({bit[type]})";
            }
            catch (Exception)
            {
                return "未知格式代码";
            }
        }
    }
    public class CheatConditional32 : CheatCode
    {
        public override string Interpreter(string code, ref int offset)
        {
            try
            {
                var regex = new Regex(@"\b([3-6])([\dA-F]{7})\s+?([\dA-F]{8})\b");
                var mathc = CheckFormat(regex, code);

                var type = Convert.ToUInt32(mathc.Groups[1].Value, 16);
                var addr = Convert.ToInt32(mathc.Groups[2].Value, 16);
                var value = Convert.ToInt32(mathc.Groups[3].Value, 16);

                var operators = new string[4] { ">","<","==","!="};

                return $"如果 [{addr:X} + {offset:X}] 的值{operators[type-3]} {value:X},则继续执行 )";
            }
            catch (Exception)
            {
                return "未知格式代码";
            }
        }
    }

    public class CheatConditional16 : CheatCode
    {
        public override string Interpreter(string code, ref int offset)
        {
            try
            {
                var regex = new Regex(@"\b([7-9A])([\dA-F]{7})\s+?([\dA-F]{4})([\dA-F]{4})\b");
                var mathc = CheckFormat(regex, code);

                var type = Convert.ToUInt32(mathc.Groups[1].Value, 16);
                var addr = Convert.ToInt32(mathc.Groups[2].Value, 16);
                var mask = Convert.ToInt32(mathc.Groups[2].Value, 16);
                var value = Convert.ToInt32(mathc.Groups[3].Value, 16);

                var operators = new string[4] { ">", "<", "==", "!=" };

                return $"如果 [{addr:X} + {offset:X}] 的值{operators[type - 7]} {value:X},则继续执行 )";
            }
            catch (Exception)
            {
                return "未知格式代码";
            }
        }
    }
}