using System;
using System.Text;

namespace Leetcode.MyAtoi
{
	public class Solution
	{
		public int MyAtoi(string s)
		{
			var cleanString = s.TrimStart()
				.ToArray();
			if (!(cleanString.Length > 0)
				|| (cleanString.Length == 1 && !Char.IsDigit(cleanString[0])))
			{
				return 0;
			}
			int index = 0;
			// Search for the first digit or minus sign
			if(index < cleanString.Length
				&& !Char.IsDigit(cleanString[index])
				&& cleanString[index] != '-'
				&& cleanString[index] != '+')
            {
				return 0;
            }
			// Adjust start position if starts with minus
			int multiplyer;
			if (cleanString[index] == '-')
            {
				multiplyer = -1;
				++index;
            }
            else if(cleanString[index] == '+')
            {
				++index;
				multiplyer = 1;
			}
			else
			{
				multiplyer = 1;
            }
			if (index < cleanString.Length
				&& !Char.IsDigit(cleanString[index])) {
				return 0;
			}
			var result = new StringBuilder();
			var removeLeadingZero = true;
			while(index < cleanString.Length
				&& Char.IsDigit(cleanString[index]))
            {
				if(removeLeadingZero
					&& cleanString[index] == '0')
                {
					++index;
					continue;
				}
				if (removeLeadingZero
					&& cleanString[index] != '0')
                {
					removeLeadingZero = false;
                }
				result.Append(cleanString[index]);
				++index;
            }
			var resultString = result.ToString();
			if(resultString.Length > 10)
            {
				return multiplyer > 0 ? int.MaxValue : Int32.MinValue;
            }
			var number = Convert.ToInt64(resultString) * multiplyer;

			if (number > Int32.MaxValue) return Int32.MaxValue;
			else if (number < Int32.MinValue) return Int32.MinValue;
			else return (int)number;
		}
	}
}

