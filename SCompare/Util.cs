using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCompare
{
	public static class Util
	{
		public static string Reverse(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

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
	}
}
