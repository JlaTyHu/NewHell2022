namespace NewHell
{
    using NewHell.Entities;
    using NewHell.Validations;
    using System;
    internal class BusinessComputerGamesManagement
    {
        public Game[] games;

        public void SetGameData()
        {
            DrawRectangle.DrawRectangleExtension();

            Console.WriteLine("\nMake youre choice: ");
            TaskBorder();
            int userChoice = Int32.Parse(Console.ReadLine());

            Game game1 = new Game
            {
                GameId = ValidationComputerGameService.ValidationGameId("32"),
                Name = ValidationComputerGameService.ValidationGameName("Stalker2"),
                Type = ValidationComputerGameService.ValidationType("Shooter"),
                Size = ValidationComputerGameService.ValidationSize(100),
                Price = ValidationComputerGameService.ValidationPrice(45),
                Country = ValidationComputerGameService.ValidationCountry("Ukraine"),                          
                YearOfRelease = ValidationComputerGameService.ValidationYearOfRelease(2023)
            };

            switch (userChoice)
            {
                case 1: AddComputerGame(); break;
                case 2: GetComputerGames(); break;
                case 3: UpdateExistGame(game1); break;
            }
        }

        public Game AddComputerGame()
        {
            RulesHowToAddGameOrUpdate();

            Game game = new Game
            {
                GameId = ValidationComputerGameService.ValidationGameId(Console.ReadLine()),
                Name = ValidationComputerGameService.ValidationGameName(Console.ReadLine()),
                Type = ValidationComputerGameService.ValidationType(Console.ReadLine()),
                Size = ValidationComputerGameService.ValidationSize(Int32.Parse(Console.ReadLine())),
                Price = ValidationComputerGameService.ValidationPrice(Double.Parse(Console.ReadLine())),
                Country = ValidationComputerGameService.ValidationCountry(Console.ReadLine()),
                YearOfRelease = ValidationComputerGameService.ValidationYearOfRelease(Int32.Parse(Console.ReadLine()))
            };

            return game;
        }

        public Game[] GetComputerGames()
        {
            var game = GetFirstDefaultGame();
            Console.WriteLine($"\nGameID: {game.GameId}\nName: {game.Name}\nType: {game.Type}\nSize: {game.Size} GB\nPrice: {game.Price}$\nCountry{game.Country}\nYear of release: {game.YearOfRelease}\n");

            var game2 = GetSecondDefaultGame();
            Console.WriteLine($"\nGameID: {game2.GameId}\nName: {game2.Name}\nType: {game2.Type}\nSize: {game2.Size} GB\nPrice: {game2.Price}$\nCountry{game2.Country}\nYear of release: {game2.YearOfRelease}\n");

            games = new Game[2] { game, game2 };

            return games;
        }

        public void UpdateExistGame(Game updateGame)
        {
            Console.WriteLine("Enter the id of the updated game");

            string userInputId = Console.ReadLine();

            var gameData = GetComputerGameById(userInputId);

            if (gameData != null)
            {
                gameData.GameId = ValidationComputerGameService.ValidationGameId(updateGame.GameId);
                gameData.Name = ValidationComputerGameService.ValidationGameName(updateGame.Name);
                gameData.Country = ValidationComputerGameService.ValidationCountry(updateGame.Country);
                gameData.Price = ValidationComputerGameService.ValidationPrice(updateGame.Price);
                gameData.Size = ValidationComputerGameService.ValidationSize(updateGame.Size);
                gameData.Type = ValidationComputerGameService.ValidationType(updateGame.Type);
                gameData.YearOfRelease = ValidationComputerGameService.ValidationYearOfRelease(updateGame.YearOfRelease);
            }

            Console.WriteLine($"\nGameID: {gameData.GameId}\nName: {gameData.Name}\nType: {gameData.Type}\nSize: {gameData.Size} GB\nPrice: {gameData.Price}$\nCountry{gameData.Country}\nYear of release: {gameData.YearOfRelease}\n"); ;
        }

        #region Private methods
        private void TaskBorder()
        {
            Console.WriteLine("1.Adding a game.\n2.Display a list of games.\n3.Updating a game.");
        }

        private Game GetComputerGameById(string gameId)
        {
            var data = this.GetComputerGames();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].GameId == gameId)
                {
                    return data[i];
                }
            }

            return new Game();
        }

        private Game GetFirstDefaultGame()
        {
            Game game = new Game
            {
                GameId = ValidationComputerGameService.ValidationGameId("12"),
                Name = ValidationComputerGameService.ValidationGameName("Valorant"),
                Type = ValidationComputerGameService.ValidationType("Shooter"),
                Size = ValidationComputerGameService.ValidationSize(20),              
                Price = ValidationComputerGameService.ValidationPrice(1),
                Country = ValidationComputerGameService.ValidationCountry("USA"),               
                YearOfRelease = ValidationComputerGameService.ValidationYearOfRelease(2020)
            };

            return game;
        }

        private Game GetSecondDefaultGame()
        {
            Game game = new Game
            {
                GameId = ValidationComputerGameService.ValidationGameId("54"),
                Name = ValidationComputerGameService.ValidationGameName("Genshin"),
                Type = ValidationComputerGameService.ValidationType("Action/RPG"),
                Size = ValidationComputerGameService.ValidationSize(50),
                Price = ValidationComputerGameService.ValidationPrice(1),
                Country = ValidationComputerGameService.ValidationCountry("China"),
                YearOfRelease = ValidationComputerGameService.ValidationYearOfRelease(2020)
            };

            return game;
        }

        private void RulesHowToAddGameOrUpdate()
        {
            Console.WriteLine("\nThe game has the following settings:");

            Console.WriteLine("1) Game ID.");

            Console.WriteLine("2) Game Name.");

            Console.WriteLine("3) Game Type.");

            Console.WriteLine("4) Game Size.");

            Console.WriteLine("5) Game Price.");

            Console.WriteLine("6) Game Country.");

            Console.WriteLine("7) Game Year of release.\n");
        }

        #endregion
    }
}
