namespace NewHell.Validations
{
    using System;

    internal static class ValidationComputerGameService
    {
        public static string ValidationGameId(string gameId)
        {
            if (gameId.Length == 0 || gameId.Length > 10 || gameId.Contains("@") || gameId.Contains(" ") || string.IsNullOrEmpty(gameId))
            {
                throw new Exception("Error input! Digit cant equal 0 , and cant big than 10 symbols, or have '@' , or space, or empty, or the same ID!");
            }

            return gameId;
        }

        public static string ValidationGameName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length > 10 || name.Contains(" "))
            {
                throw new Exception("Error input! Game name cant empty, or big than 10 symbols, or have space, or the same names!");
            }

            return name;
        }

        public static string ValidationType(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                throw new Exception("Error! Empty field!");
            }

            return type;
        }

        public static int ValidationSize(int size)
        {
            if (size == 0 || size > 150 || size < 1)
            {
                throw new Exception("Error! Size cant equal 0 , or less than 1, or big than 150!");
            }

            return size;
        }

        public static double ValidationPrice(double price)
        {
            if (price == 0 || price > 50 || price < 1)
            {
                throw new Exception("Error input! Price cant equal 0, or big than 50, or less than 1!");
            }

            return price;
        }

        public static string ValidationCountry(string country)
        {
            if (string.IsNullOrEmpty(country) || char.IsLower(country[0]) || country.Length < 3)
            {
                throw new Exception("Error input! Country cant empty, or start with a small letter, or less than 3 char!");
            }

            return country;
        }

        public static int ValidationYearOfRelease(int yearOfRelease)
        {
            if (yearOfRelease == 0 || yearOfRelease > 2025 || yearOfRelease < 1990)
            {
                throw new Exception("Error input! Year of Release cant equal 0, or big than 2025, or less than 1990!");
            }

            return yearOfRelease;
        }
    }
}
