using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCompareUtil
{
    /// <summary>
    /// 
    /// </summary>
    public static class CompareExtensions
    {
        /// <summary>
        /// Kiểm tra chuỗi có phải là email hay không?
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValidEmailAddress(this string s)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        /// <summary>
        ///  :D error -,..,- is numeric
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool isNumeric(this string str)
        {
            // TODO: find other way
            return str.All(c => char.IsDigit(c) || c == '.' || c == ',');
        }

        /// <summary>
        /// So sánh giá trị số của 2 chuỗi string
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static int CompareNumericValueTo(this string str1, string str2)
        {
            int rs = 0;

            int isNeStr1 = str1.IndexOf('-');
            int isNeStr2 = str2.IndexOf('-');

            // trường hợp có 1 số là số âm số còn lại là số dương thì đảo ngược lại 
            rs = isNeStr2.CompareTo(isNeStr1);
            if (rs != 0)
            {
                return rs;
            }

            int isNagative = 1;
            // nếu 1 số là số là số âm thì cả 2 số cùng là số âm
            if (isNeStr1 > -1)
            {
                // trường hợp là số âm thì kết quả compare sẽ ngược lại với số dương
                // nên sẽ nhân với isNagative nghịch đảo
                isNagative = -1;
            }

            string[] lsStr1 = str1.Split('.');
            string[] lsStr2 = str2.Split('.');

            lsStr1[0] = lsStr1[0].Replace("-", "").TrimStart('0');
            lsStr2[0] = lsStr2[0].Replace("-", "").TrimStart('0');

            // compare độ dài phần nguyên
            rs = lsStr1[0].Length.CompareTo(lsStr2[0].Length);
            if (rs != 0)
            {
                return rs * isNagative;
            }

            // so sanh phần nguyên
            rs = lsStr1[0].CompareTo(lsStr2[0]);
            if (rs != 0)
            {
                return rs * isNagative;
            }

            // phần nguyên hiện bằng nhau thì so sánh phần thập phân

            // so sánh số nào có phần thập phân
            rs = lsStr1.Length.CompareTo(lsStr2.Length);

            // trường hợp số có số không
            if (rs != 0)
            {
                return rs * isNagative;
            }

            // trường hợp cả 2 cùng không có
            if (lsStr1.Length == 1)
            {
                return 0;// bằng nhau
            }

            // phần thập phân có thể compare trực tiếp bằng string
            return lsStr1[1].CompareTo(lsStr2[1]) * isNagative;
        }

    }
}
