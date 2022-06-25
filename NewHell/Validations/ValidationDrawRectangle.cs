namespace NewHell.Validations
{
    using System;
    internal class ValidationDrawRectangle
    {
        public static int ValidationGetUserInputHeight(int userInputHeight)
        {
            if (userInputHeight < 1 || userInputHeight > 7)
            {
                throw new Exception("Error input! Minmum height 1, maximum 7!");
            }

            return userInputHeight;
        }

        public static int ValidationGetUserInputWidth(int userInputWidth)
        {           
            if (userInputWidth < 1 || userInputWidth > 6)
            {
                throw new Exception("Error input! Minmum wight 1, maximum 6!");
            }

            return userInputWidth;
        }
    }
}
