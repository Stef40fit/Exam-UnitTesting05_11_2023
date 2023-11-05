using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'A';
        char b = 'B';
        string expectedResult = ""; 

        // Act
        string result = CharacterRange.GetRange(a, b); 

        // Assert
        Assert.AreEqual(expectedResult, result);

    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'B';
        char b = 'A';
        string expectedResult = "";

        // Act
        string result = CharacterRange.GetRange(b, a);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char a = 'A';
        char c = 'C';
        string expectedResult = "B";

        // Act
        string result = CharacterRange.GetRange(a, c); 
        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char d = 'D';
        char g = 'G';
        string expectedResult = "E F";

        // Act
        string result = CharacterRange.GetRange(d, g); 
        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char x = 'X';
        char z = 'Z';
        string expectedResult = "Y";

        // Act
        string result = CharacterRange.GetRange(x, z); 
        // Assert
        Assert.AreEqual(expectedResult, result);
    }
}
