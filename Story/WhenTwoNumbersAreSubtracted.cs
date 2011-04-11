using System;
using Bddify.Core;
using NUnit.Framework;

namespace StoryDemo
{
    public class WhenTwoNumbersAreSubtracted
    {
        [RunStepWithArgs(5, 3, 2)]
        [RunStepWithArgs(1, 8, -7)]
        void ThenTheResultShouldBeCorrect(int input1, int input2, int expectedResult)
        {
            Assert.That(input1 - input2, Is.EqualTo(expectedResult));
        }
    }
}