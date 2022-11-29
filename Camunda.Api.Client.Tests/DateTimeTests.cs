using System;
using FluentAssertions;
using NUnit.Framework;

namespace Camunda.Api.Client.Tests
{
    public class DateTimeTests
    {
        [Test]
        //[TestCase("2010-05-01T01:01:01.000", "2010-05-01T01:01:01.000+0000")]
        [TestCase("2010-01-01T01:01:01", "2010-01-01T01:01:01.000+0100")]
        public void GetDateTime(string testDateTimeString,string expectedDatetimeString)
        {
           var actualIso8601DateString = DateTime.Parse(testDateTimeString).ToJavaISO8601();
           actualIso8601DateString.Should().Be(expectedDatetimeString);
        }
    }
}
