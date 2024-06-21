# NumberPrettifier

NumberPrettifier is a C# class library that provides functionality to prettify large numbers by converting them into more readable formats using suffixes such as "M" for millions, "B" for billions, and "T" for trillions. This library is designed to handle numbers greater than 6 digits and ensure the prettified version includes one number after the decimal when the truncated number is not an integer.

## Problem Overview

The goal is to convert large numbers into a human-readable format using appropriate suffixes:
- Numbers greater than 6 digits are prettified.
- Supports millions (M), billions (B), and trillions (T).
- The prettified version should include one number after the decimal when the truncated number is not an integer.

## Assumptions

- Negative numbers are not handled and will return a specific message "Negative Number".
- The library is designed to prettify numbers up to trillions. Numbers greater than or equal to quadrillions will return a message "Number greater than Trillion".


## Classes

### 1. NumberPrettifier.Prettifier

This class contains the `PrettifyNumber` method which converts large numbers into a prettified string format using the appropriate suffix.

#### Methods

- **PrettifyNumber(double number)**: Takes a double value and returns a prettified string representation of the number. Handles edge cases like negative numbers, NaN, and Infinity.

### 2. TestNumberPrettifier.PrettifierTests

This class contains unit tests to verify the correctness of the `Prettifier.PrettifyNumber` method. Uses NUnit framework for testing.

#### Overview of Test Cases

The unit tests cover various scenarios to ensure the `Prettifier.PrettifyNumber` method behaves correctly for a wide range of inputs:

1. **Basic Cases**:
   - **Input 1000000 should return "1M"**
   - **Input 2560000.34 should return "2.6M"**
   - **Input 2500000.34 should return "2.5M"**
   - **Input 532 should return "532"**
   - **Input 1123456789 should return "1.1B"**
   - **Input 1500 should return "1500"**
   - **Input 999999 should return "999999"**
   - **Input 1000000000000 should return "1T"**
   - **Input 0 should return "0"**
   - **Input -1234567890 should return "Negative Number"**
   - **Input 987654321 should return "987.7M"**
   - **Input 4500 should return "4500"**

2. **Edge Cases**:
   - **Large number in trillions**:
     - **Input 123456789012345 should return "123.5T"**
   - **Small decimal number**:
     - **Input 0.12345 should return "0.1"**
   - **Decimal number rounded to one decimal place**:
     - **Input 123.456 should return "123.5"**
   - **Number with one decimal place that doesn't need rounding**:
     - **Input 5000000.5 should return "5.0M"**

3. **Special Cases**:
   - **Negative number**:
     - **Input -5000000.5 should return "Negative Number"**
   - **Zero value**:
     - **Input 0 should return "0"**
   - **Maximum double value**:
     - **Input double.MaxValue should return "Number greater than Trillion"**
   - **Minimum double value (negative)**:
     - **Input double.MinValue should return "Negative Number"**

Each test case validates the expected behavior of the `PrettifyNumber` method under specific conditions, ensuring the library handles a variety of input scenarios accurately.
