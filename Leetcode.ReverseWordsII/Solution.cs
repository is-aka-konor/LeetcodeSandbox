using System;
namespace Leetcode.ReverseWordsII
{
	public class Solution
	{
		public char[] ReverseWords(char[] s)
        {
			var stack = new Stack<char[]>();
			var buffer = new List<char>();
			for(var i = 0; i < s.Length; ++i)
            {
				if(s[i] != ' ')
				{
					buffer.Add(s[i]);
				}else if(s[i] == ' ')
				{
					stack.Push(buffer.ToArray());
					buffer = new List<char>();
				}
            }
			stack.Push(buffer.ToArray());
			buffer = null;
			var index = 0;
			var wordsCount = stack.Count;
			for(var i = 0; i < wordsCount; ++i)
			{
				var word = stack.Pop();
				for(var j = 0; j < word.Length; ++j)
				{
					s[index++] = word[j];
				}
				if(stack.Count != 0)
				{
					s[index++] = ' ';
				}
			}
			return s;
		}
	}
}