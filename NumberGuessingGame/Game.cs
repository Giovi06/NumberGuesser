using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace NumberGuessingGame.Game {
    class Game {
        private bool multiplayer;
        private bool tryAgain;
        private bool hardcore = false;
        private bool letterMode = false;
        private int player = 1;
        private int guessedNum;
        private char guessedLetter;
        private int[] numOfTries = { 1, 2 };
        private int randomNumber;
        private char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };


        public void Start()
        {
            Console.WriteLine("Willkommen zum Zahlenraten-Spiel!");
            Console.Write("Möchtest im Coop Modus spielen? (true/false): ");
            multiplayer = GetUserInput.BoolInput();

            if (!multiplayer)
            {
                Console.WriteLine("Okay, schade :( Hoffentlich finde Sie bald Freunde");
            }

            tryAgain = true;
            do
            {
                numOfTries[1] = 0;
                if (hardcore)
                {
                    PlayNumberGuesser(1, 1000, multiplayer);
                }
                if (letterMode)
                {
                    PlayLetterGuesser(multiplayer,1,26);
                }
                if (!letterMode && !hardcore)
                {
                    PlayNumberGuesser(1, 100, multiplayer);
                }

                Console.WriteLine("Möchten Sie eine weitere Runde spielen? (true/false)");
                tryAgain = GetUserInput.BoolInput();

                if (tryAgain)
                {
                    hardcore = false;
                    letterMode = false;
                    Console.WriteLine("Super, das freut mich.");
                    if (numOfTries[player - 1] < 6)
                    {
                        Console.WriteLine("Möchten Sie Hardcore Spielmodus spielen?? (true/false)");
                        hardcore = GetUserInput.BoolInput();
                    }
                    if (numOfTries[player - 1] < 10 && !hardcore)
                    {
                        Console.WriteLine("Möchten Sie Buchstaben erraten? (true/false) ");
                        letterMode = GetUserInput.BoolInput();
                    }
                }
                if (!tryAgain) {
                    Console.WriteLine("Okay, schade Hoffentlich sehen wir uns bald wieder");
                }
            } while (tryAgain);
        }
        private void PlayNumberGuesser(int minValue, int maxValue, bool multiplayer)
        {
            numOfTries[0] = 0;
            numOfTries[1] = 0;
            randomNumber = Generator.GenerateRandomNumber(minValue, maxValue);
            do
            {
                if (multiplayer)
                {
                    Console.Write($"Spieler {player}, gib eine Ziffer zwischen {minValue}-{maxValue}  ein: ");
                }
                else
                {
                    Console.WriteLine($"Geben Sie bitte eine Zahl zwischen {minValue}-{maxValue} ein:");
                }

                guessedNum = GetUserInput.IntInput();
                switch (guessedNum)
                {
                    case int n when (n < minValue):
                    case int m when (m > maxValue):
                        Console.WriteLine($"Ungültige Eingabe: Ihre Zahl befindet sich nicht zwischen {minValue}-{maxValue} !");
                        break;
                    case int n when (guessedNum == randomNumber):
                        numOfTries[player - 1]++;

                        switch (numOfTries)
                        {
                            case int[] when (numOfTries[player - 1] == 1):
                                Console.WriteLine($"Glückwunsch, Sie haben es geschafft mit nur einem Versuch! ");
                                break;
                            case int[] when (numOfTries[player - 1] < 6):
                                Console.WriteLine($"Super, Sie haben es geschafft mit nur {numOfTries[player - 1]} Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                break;
                            case int[] when (numOfTries[player - 1] < 10):
                                Console.WriteLine($"Okay, Sie haben es geschafft mit {numOfTries[player - 1]} Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                break;
                            case int[] when (numOfTries[player - 1] < 21):
                                Console.WriteLine($"Sie haben mit {numOfTries[player - 1]} Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                break;
                            case int[] when (numOfTries[player - 1] > 20):
                                Console.WriteLine($"Sind wir ehrlich {numOfTries[player - 1] - 1} Mal eine Zahl zu erraten und es erst beim {numOfTries[player - 1]}ten Mal zu erraten ist garnicht mal so gut.");
                                break;
                        }
                        return;
                    case int when guessedNum > (minValue - 1) && guessedNum < maxValue + 1:
                        if (guessedNum < randomNumber)
                        {
                            minValue = guessedNum;
                            Console.WriteLine($"Die Zufallszahl liegt zwischen {minValue} und {maxValue}");
                        }
                        else if (guessedNum > randomNumber)
                        {
                            maxValue = guessedNum;
                            Console.WriteLine($"Die Zufallszahl liegt zwischen {minValue} und {maxValue}");
                        }
                        numOfTries[player - 1]++;
                        break;
                }
                if (multiplayer)
                {
                    player = (player == 1) ? 2 : 1;
                }

            } while (true);
        }
        private void PlayLetterGuesser(bool multplayer, int minValue, int maxValue)
        {
            int b = Generator.GenerateRandomNumber(minValue, maxValue);
            char lowestLetter = 'a';
            char highestLetter = 'z';
            do
            {

                if (multiplayer)
                {
                    Console.Write($"Spieler {player}, gib ein Buchstabe von {lowestLetter}-{highestLetter} ein: ");
                }
                else
                {
                    Console.WriteLine("Geben sie einen buchstaben ein ");
                }
                guessedLetter = GetUserInput.CharInput();
                try
                {

                    switch (guessedLetter)
                    {
                        case char n when (guessedLetter == letters[b]):
                            numOfTries[player - 1]++;

                            switch (numOfTries)
                            {
                                case int[] when (numOfTries[player - 1] == 1):
                                    Console.WriteLine($"Glückwunsch, Sie haben es geschafft mit nur einem Versuch! ");
                                    break;
                                case int[] when (numOfTries[player - 1] < 6):
                                    Console.WriteLine($"Super, Sie haben es geschafft mit nur {numOfTries[player - 1]} Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                    break;
                                case int[] when (numOfTries[player - 1] < 10):
                                    Console.WriteLine($"Okay, Sie haben es geschafft mit {numOfTries[player - 1]} Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                    break;
                                case int[] when (numOfTries[player - 1] < 21):
                                    Console.WriteLine($"Sie haben mit {numOfTries[player - 1]} Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                    break;
                                case int[] when (numOfTries[player - 1] > 20):
                                    Console.WriteLine($"Sind wir ehrlich {numOfTries[player - 1] - 1} Mal eine Zahl zu erraten und es erst beim {numOfTries[player - 1]}ten Mal zu erraten ist garnicht mal so gut.");
                                    break;
                            }
                            return;
                        case char when (b > 0):
                            if (guessedLetter < letters[b])
                            {
                                lowestLetter = guessedLetter;
                                Console.WriteLine($"Die Zufallszahl liegt zwischen {lowestLetter} und {highestLetter}");
                            }
                            else if (guessedLetter > letters[b])
                            {
                                highestLetter = guessedLetter;
                                Console.WriteLine($"Die Zufallszahl liegt zwischen {lowestLetter} und {highestLetter}");
                            }
                            numOfTries[player - 1]++;
                            break;
                    }
                    player = (player == 1) ? 2 : 1;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            } while (true);
        }

    }
}
