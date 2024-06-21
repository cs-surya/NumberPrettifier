using NUnit;
using NumberPrettifier;

namespace TestNumberPrettifier;


[TestFixture]
public class PrettifierTests
{
    // Test cases for PrettifyNumber method

    // Test case: Input 1000000 should return "1M"
    [TestCase(1000000, ExpectedResult = "1M")]

    // Test case: Input 2560000.34 should return "2.6M"
    [TestCase(2560000.34, ExpectedResult = "2.6M")]

    // Test case: Input 2500000.34 should return "2.5M"
    [TestCase(2500000.34, ExpectedResult = "2.5M")]

    // Test case: Input 532 should return "532"
    [TestCase(532, ExpectedResult = "532")]

    // Test case: Input 1123456789 should return "1.1B"
    [TestCase(1123456789, ExpectedResult = "1.1B")]

    // Test case: Input 1500 should return "1500"
    [TestCase(1500, ExpectedResult = "1500")]

    // Test case: Input 999999 should return "999999"
    [TestCase(999999, ExpectedResult = "999999")]

    // Test case: Input 1000000000000 should return "1T"
    [TestCase(1000000000000, ExpectedResult = "1T")]

    // Test case: Input 0 should return "0"
    [TestCase(0, ExpectedResult = "0")]

    // Test case: Input -1234567890 should return "Negative Number"
    [TestCase(-1234567890, ExpectedResult = "Negative Number")]

    // Test case: Input 987654321 should return "987.7M"
    [TestCase(987654321, ExpectedResult = "987.7M")]

    // Test case: Input 4500 should return "4500"
    [TestCase(4500, ExpectedResult = "4500")]

    // Large number in trillions
    [TestCase(123456789012345, ExpectedResult = "123.5T")]

    // Small decimal number
    [TestCase(0.12345, ExpectedResult = "0.1")]

    // Decimal number rounded to one decimal place
    [TestCase(123.456, ExpectedResult = "123.5")]

    // Number with one decimal place that doesn't need rounding
    [TestCase(5000000.5, ExpectedResult = "5.0M")]

    // Negative number (assuming it returns "Negative Number")
    [TestCase(-5000000.5, ExpectedResult = "Negative Number")]

    // Zero value
    [TestCase(0, ExpectedResult = "0")]

    // Maximum double value
    [TestCase(double.MaxValue, ExpectedResult = "Number greater than Trillion")]

    // Minimum double value (negative)
    [TestCase(double.MinValue, ExpectedResult = "Negative Number")]

    // Method under test: PrettifyNumber_ReturnsPrettifiedString
    public string PrettifyNumber_ReturnsPrettifiedString(double number)
    {
        // Call Prettifier.PrettifyNumber method and return the result
        return Prettifier.PrettifyNumber(number);
    }
}
