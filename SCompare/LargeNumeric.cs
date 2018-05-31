using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCompare
{
	class LargeNumeric
	{

		public static string sum(string strNum1, string strNum2)
		{
			if (string.IsNullOrEmpty(strNum1) || string.IsNullOrEmpty(strNum2))
			{
				return "";
			}

			int maxLength = strNum2.Length;

			if (strNum1.Length < strNum2.Length)
			{
				maxLength = strNum2.Length;

				string temp = strNum1;
				strNum1 = strNum2;
				strNum2 = temp;
			}

			strNum1 = Util.Reverse(strNum1);
			strNum2 = Util.Reverse(strNum2);

			StringBuilder sb = new StringBuilder();
			int tempRs = 0;
			int surplus = 0;
			for (int i = 0; i < maxLength; i++)
			{
				if (i >= strNum2.Length)
				{
					tempRs = sumSimple(strNum1[i], '0') + surplus;
				}
				else
					tempRs = sumSimple(strNum1[i], strNum2[i]) + surplus;
				surplus = tempRs > 9 ? 1 : 0;
				sb.Append(tempRs % 10);
			}
			if (surplus == 1)
				sb.Append(1);

			return Util.Reverse(sb.ToString());
		}

		static int sumSimple(char a, char b)
		{
			int rs = 0;
			int cons = 48;
			rs = (((int)a) - cons) + (((int)b) - cons);
			return rs;
		}
	}
}
