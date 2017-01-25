using System;
using NUnit.Framework;

[TestFixture]
public class ShadesOfGreyTests
{
    [Test]
    public void ShadesOfGreyWithOneShouldReturnOne()
    {
        Assert.AreEqual("#010101", Kata.ShadesOfGrey(1)[0]);
    }
}

