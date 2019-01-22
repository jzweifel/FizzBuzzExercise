using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz {
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
    public class FizzBuzzTest {
        [Fact]
        public void GivenArrayOf1_ReturnsArrayWithString1 () {
            var input = new List<int> () { 1 };
            var expected = new List<string> () { "1" };

            var actual = FizzBuzz.GetFizzBuzz (input);

            Assert.Equal (expected, actual);
        }
    }
}
