using System;
using System.Text;

namespace Leetcode.MyAtoi
{
	public class Solution
	{
		public int MyAtoi(string s)
		{
			var cleanString = s.TrimStart();
			if (!(cleanString.Length > 0)
				|| (cleanString.Length == 1 && !Char.IsDigit(cleanString[0])))
			{
				return 0;
			}
			int index = 0;
			var length = cleanString.Length;
			// Search for the first digit or a sign symbol
			if (index < length
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
				multiplyer = 1;
				++index;
				
			}
			else
			{
				multiplyer = 1;
            }
			if (index < length
				&& !Char.IsDigit(cleanString[index])) {
				return 0;
			}
			
			while(index < length
					&& cleanString[index] == '0')
            {
				++index;
            };
			var result = new StringBuilder();
			while (index < length
				&& Char.IsDigit(cleanString[index]))
            {
				result.Append(cleanString[index]);
				++index;
            }
			var stringResult = result.ToString();
			if (stringResult.Length > 10)
            {
				return multiplyer > 0 ? int.MaxValue : Int32.MinValue;
            }
			if (result.Length == 0) return 0;
			var number = Convert.ToInt64(stringResult) * multiplyer;

			if (number > Int32.MaxValue) return Int32.MaxValue;
			else if (number < Int32.MinValue) return Int32.MinValue;
			else return (int)number;
		}
	}
}

