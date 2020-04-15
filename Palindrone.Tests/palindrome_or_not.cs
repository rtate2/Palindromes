using System;
using Xunit;

namespace Palindromes.Tests
{
    public class palindrome_or_not
    {
        [Fact]
        public void stars_palindrome_or_not()
        {
            var palindrome = "stars";
            var expectedResult = false;
            var palindromeChecker = new PalindromeChecker();

            var actualResult = palindromeChecker.Check(palindrome);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void o_a_kak_Uwakov_lil_vo_kawu_kakao_palindrome_or_not()
        {
            var palindrome = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var palindromeChecker = new PalindromeChecker();

            var actualResult = palindromeChecker.Check(palindrome);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void some_men_interpret_nine_memos_palindrome_or_not()
        {
            var palindrome = "Some men interpret nine memos";
            var expectedResult = true;
            var palindromeChecker = new PalindromeChecker();

            var actualResult = palindromeChecker.Check(palindrome);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}