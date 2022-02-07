using System.Collections.Generic;
using Xunit;

namespace Leetcode.GroupAnagrams.Tests;

public class GroupAnagramsTestInput
{
    public string[]? Input { get; set; }
    public IList<IList<string>> Result { get; set; } = new List<IList<string>>();
}

public class GroupAnagramsTests
{
    [Theory]
    [MemberData(nameof(GroupAnagramsData), MemberType = typeof(GroupAnagramsTests))]
    public void ShouldPassGroupAnagramsTests(GroupAnagramsTestInput data)
    {
        var solutionImplementation = new Solution();
        if (data.Input != null)
        {
            var result = solutionImplementation.GroupAnagrams(data.Input);
            Assert.Equal(data.Result, result);
        }
    }

    public static TheoryData<GroupAnagramsTestInput> GroupAnagramsData =>
        new TheoryData<GroupAnagramsTestInput>()
        {
            new GroupAnagramsTestInput()
            {
                Input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                Result = new List<IList<string>>()
                {
                    new List<string>() { "eat", "tea", "ate" },
                    new List<string>() { "tan", "nat" },
                    new List<string>() { "bat" }
                }
            },
            new GroupAnagramsTestInput()
            {
                Input = new string[] { "a"},
                Result = new List<IList<string>>()
                {
                    new List<string>() { "a" }
                }
            },
            new GroupAnagramsTestInput()
            {
                Input = new string[] { "", "", ""},
                Result = new List<IList<string>>()
                {
                    new List<string>() { "" }
                }
            }
        };
}