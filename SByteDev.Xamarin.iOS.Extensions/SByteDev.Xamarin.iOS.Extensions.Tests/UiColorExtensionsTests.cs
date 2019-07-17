using System;
using NUnit.Framework;
using UIKit;

namespace SByteDev.Xamarin.iOS.Extensions.Tests
{
    [TestFixture]
    public class UiColorExtensionsTests
    {
        [TestFixture]
        public class WhenToHexColorCalled
        {
            [TestFixture]
            public class AndTheColorIsNull
            {
                [Test]
                public void ExceptionShouldBeThrown()
                {
                    Assert.Throws<ArgumentNullException>(() => default(UIColor).ToHexColor());
                }
            }

            [Test]
            [TestCase(129, 45, 211, 1, "#FF812DD3")]
            [TestCase(237f, 107f, 7f, .5f, "#7FED6B07")]
            [TestCase(45, 189, 100, 0, "#002DBD64")]
            public void CorrectHexStringShouldBeReturned(float red, float green, float blue, float alpha, string hex)
            {
                Assert.AreEqual(hex, new UIColor(red / 255, green / 255, blue / 255, alpha).ToHexColor());
            }
        }
    }
}