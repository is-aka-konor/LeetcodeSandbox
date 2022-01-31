using Xunit;

namespace Leetcode.ValidPalindrome.Tests;

public class ValidPalindromeInput
{
    public string Input { get; set; } = string.Empty;
    public bool Result { get; set; }
}
public class ValidPalindromeTests
{
    [Theory]
    [MemberData(nameof(IsValidPalindromeData), MemberType = typeof(ValidPalindromeTests))]
    public void SohuldPassValidPalindromeTests(ValidPalindromeInput data)
    {
        var solutionImplementation = new Solution();
        var targetResult = solutionImplementation.IsPalindrome(data.Input);
        Assert.Equal(data.Result, targetResult);
    }

    public static TheoryData<ValidPalindromeInput> IsValidPalindromeData =>
        new TheoryData<ValidPalindromeInput>
        {
            new ValidPalindromeInput {
                Input = " ",
                Result = true
            },
            new ValidPalindromeInput {
                Input = " WoW ",
                Result = true
            },
            new ValidPalindromeInput {
                Input = " ,121! ",
                Result = true
            },
            new ValidPalindromeInput {
                Input = "A man, a plan, a canal: Panama",
                Result = true
            },
            new ValidPalindromeInput {
                Input = "race a car",
                Result = false
            },
            new ValidPalindromeInput {
                Input = "!Miro !Miro",
                Result = false
            },
        };
}
