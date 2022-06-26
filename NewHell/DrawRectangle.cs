namespace NewHell
{
    using System;
    using NewHell.Validations;
    public static class DrawRectangle
    {
        public static void DrawRectangleExtension()
        {
            string paintSymbolSingl = "@";

            Console.Write("Input height = ");
            int userInputHeight = ValidationDrawRectangle.ValidationGetUserInputHeight(Int32.Parse(Console.ReadLine()));
          
            Console.Write("Please, input wight = ");
            int userInputWidth = ValidationDrawRectangle.ValidationGetUserInputWidth(Int32.Parse(Console.ReadLine()));

            string paintSymbol = CheckSymbols(userInputWidth);
            string emptySpace = CheckEmptySpace(userInputWidth);

            string[] paint = new string[userInputHeight];

            for (int i = 0; i < paint.Length; i++) // W
            {
                paint[i] = paintSymbol;
            }

            if (userInputWidth != 1)
            {
                for (int i = 1; i < paint.Length - 1; i++) // H
                {
                    paint[i] = paintSymbolSingl + emptySpace + paintSymbolSingl;                   
                }
            }
            
            foreach (var item in paint)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Welcome to the information system on computer games.");
        }

        private static string CheckSymbols(int width )
        {
            string paintSymbol;

            if(width == 1)
            {
                paintSymbol = "@";
            }
            else if(width == 2)
            {
                paintSymbol = "@@";
            }
            else if(width == 3)
            {
                paintSymbol = "@@@";
            }
            else if(width == 4)
            {
                paintSymbol = "@@@@";
            }
            else if(width == 5)
            {
                paintSymbol = "@@@@@";
            }
            else
            {
                paintSymbol = "@@@@@@";
            }

            return paintSymbol;
        }
        
        private static string CheckEmptySpace(int width)
        {
            string emptySpace;

            if (width == 1 || width == 2)
            {
                emptySpace = "";
            }
            else if (width == 3)
            {
                emptySpace = " ";
            }
            else if (width == 4)
            {
                emptySpace = "  ";
            }
            else if (width == 5)
            {
                emptySpace = "   ";
            }
            else
            {
                emptySpace = "    ";
            }

            return emptySpace;
        }
    }
}
