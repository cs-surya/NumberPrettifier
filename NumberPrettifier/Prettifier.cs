namespace NumberPrettifier
{

    public static class Prettifier
    {
        
        public static string PrettifyNumber(double number)
        {
            //define thresholdfor million and quadrillion
            const double millionThreshold = 1_000_000;
            const double quadrillionThreshold = 1_000_000_000_000_000;

            string suffix = "";
            //assuming negative numbers should not be prettified
            if (number < 0)
            {
                // return custom message
                return "Negative Number";
            }

           //since the requirement is to prettify numbers greater than 6 digits
            if (number < millionThreshold)
            {
                //return the given number as string if its less than a million
                return number.ToString();
            }

            // assuming the requirement is to prettify numbers only utpo trillions
            else if (number >= quadrillionThreshold)
            {
                //if the input is >=quadrillion
                return "Number greater than Trillion";
            }
            //calculate the exponent based on log base 10
            int exponent =(int) Math.Log10(number) / 3;  //dividing the exponent by 3 finds the magnitude of the number

            switch (exponent)
            {
                //if the exponent is 2, then logarithm base 1000 of the number is between 6 and 9
                case 2:
                    suffix = "M";// return Million
                    break;
                //if the exponent is 3, then logarithm base 1000 of the number is between 9 and 12
                case 3:
                    suffix = "B"; //return Billion
                    break;
                //if the exponent is 4, then logarithm base 1000 of the number is between 12 and 15
                case 4:
                    suffix = "T"; //return Trillion
                    break;
                default:
                    suffix = ""; // default suffix
                    break;
            }

            // Scale the number down appropriately based on the exponent
            double scaledNumber = number / Math.Pow(1000, exponent);
            // Format the scaled number with one decimal place. It will also round off the deciaml to nearest digit
            string prettifiedNumber = scaledNumber % 1 == 0 ? scaledNumber.ToString("0") : Math.Round(scaledNumber, 1).ToString("0.0");
            //return the number which is prettifed
            return prettifiedNumber + suffix;
        }


    }
}