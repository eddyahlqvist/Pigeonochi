using System;
using System.Collections.Generic;

namespace Pigeonotchi
{
    internal class Simulation
    {
        bool _simIsRunning = true;

        private readonly Pigeon _pigeon;

        private readonly Player _player;

        private readonly Dictionary<int, string> _menuOptions = [];

        public Simulation()
        {
            _pigeon = new Pigeon("Suspicious Pigeon");
            _player = new Player("Unknown");
        }

        public void Run()
        {
            BuildMainMenu();

            while (_simIsRunning)
            {                
                DisplayMainMenu();
                Console.WriteLine();
                Console.WriteLine("Pick an option from the menu: ");

                int choice = GetMenuChoice();
                HandleMenuChoice(choice);
            }
        }

        private void HandleMenuChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    ViewPigeon();
                    break;

                case 2:
                    ViewPlayer();
                    break;

                case 3:
                    Console.WriteLine("Not saving... farewell though!\n"); // tmp message
                    _simIsRunning = false;
                    break;

                default:
                    break;
            }
        }

        private void ViewPigeon()
        {
            Console.WriteLine($"You see {_pigeon.Name}. He glares back at you. \n"); // tmp message
        }

        private void ViewPlayer()
        {
            Console.WriteLine($"You are {_player.Name} and you love your pet {_pigeon.Name}. \n"); // tmp message
        }

        private int GetMenuChoice()
        {
            while (true)
            {
                string input = Console.ReadLine()?.Trim() ?? "";

                if (int.TryParse(input, out int choice) &&
                    _menuOptions.ContainsKey(choice))
                {
                    return choice;
                }

                Console.Write("Invalid choice. Pick an option from the menu: ");
            }
        }

        private void BuildMainMenu()
        {
            _menuOptions.Add(1, "View Pigeon");
            _menuOptions.Add(2, "View Player");
            _menuOptions.Add(3, "Quit");
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("==== Pigeonotchi ====");
            Console.WriteLine();

            foreach (var menuOption in _menuOptions)
            {
                Console.WriteLine($"{menuOption.Key}: {menuOption.Value}");
            }
        }
    }
}
