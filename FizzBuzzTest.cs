using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz
{
    /*

    The Three Rules of TDD
    1. You are not allowed to write any production code unless it is to
        make a failing unit test pass.
    2. You are not allowed to write any more of a unit test than is sufficient
        to fail; and compilation failures are failures.
    3. You are not allowed to write any more production code than is sufficient
        to pass the one failing unit test.

    Which means the workflow is:

    1. Write a failing test. Stop writing the test as soon as it fails.
    2. Write the minimal production code required for the test to pass.
        Stop writing any code once the test passes.
    3. Refactor the test code and the production code without altering the functionality.
        All tests should pass.

    */
    public class FizzBuzzTest
    {
        [Fact]
        public void GivenArrayOf1_ReturnsArrayWithString1()
        {
            var input = new List<int>() { 1 };
            var expected = new List<string>() { "1" };

            var actual = FizzBuzz.GetFizzBuzz(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenNullArray_ReturnsNull()
        {
            var actual = FizzBuzz.GetFizzBuzz(null);

            Assert.Equal(null, actual);
        }

        [Fact]
        public void GivenArrayOfSize_NReturnsArrayOfSizeN()
        {
            var input = new List<int>() { 1, 2 };

            Assert.Equal(input.Count, FizzBuzz.GetFizzBuzz(input).Count);
        }

        [Fact]
        public void GivenArrayOfIntegers_ReturnArrayOfStrings()
        {
            var input = new List<int>() { 1, 2, 4 };
            var expected = new List<string>() { "1", "2", "4" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsMultiplesOf3_ReturnArrayContainsFizz()
        {
            var input = new List<int>() {1, 2, 3, 6};
            var expected = new List<string>() { "1", "2", "Fizz", "Fizz" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsMultiplesOf5_ReturnArrayContainsBuzz()
        {
            var input = new List<int>() {1, 5, 10, 2};
            var expected = new List<string>() { "1", "Buzz", "Buzz", "2" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsMultiplesOf3And5_ReturnArrayContainsFizzBuzz()
        {
            var input = new List<int>() {1, 15, 45, 2};
            var expected = new List<string>() { "1", "FizzBuzz", "FizzBuzz", "2" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsAll_ReturnArrayContainsAll()
        {
            var input = new List<int>() {1, 3, 5, 15};
            var expected = new List<string>() { "1", "Fizz", "Buzz", "FizzBuzz" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsNegative_ReturnArrayOfNegative()
        {
            var input = new List<int>() {-1};
            var expected = new List<string>() { "-1" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsMultipleOf7_ReturnArrayContainingBang()
        {
            var input = new List<int>() {7};
            var expected = new List<string>() { "Bang!" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsMultipleOf3And7_ReturnArrayContainingFizzBang()
        {
            var input = new List<int>() {21};
            var expected = new List<string>() { "FizzBang!" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsMultipleOf5And7_ReturnArrayContainingBuzzBang()
        {
            var input = new List<int>() {35};
            var expected = new List<string>() { "BuzzBang!" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }

        [Fact]
        public void GivenArrayContainsMultipleOf3And5And7_ReturnArrayContainingFizzBuzzBang()
        {
            var input = new List<int>() {105};
            var expected = new List<string>() { "FizzBuzzBang!" };

            Assert.Equal(expected, FizzBuzz.GetFizzBuzz(input));
        }
    }
}
