using System;

namespace Hangman
{
    enum Menu { GamePage = 1, Exit }
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            
        }
        static void ShowMenu()
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Please Select Menu");
            InputMenuFromKeyBoard();
        }
        static void InputMenuFromKeyBoard()
        {
            Menu keyFromKeyboard = (Menu)int.Parse(Console.ReadLine());
            PresentMenu(keyFromKeyboard);
        }
        static void PresentMenu(Menu keyFromKeyboard)
        {
            if (keyFromKeyboard == Menu.GamePage)
            {
                ShowGamepage();
            }
            else if (keyFromKeyboard == Menu.Exit)
            {
                Console.ReadLine();
            }
        }
        static void ShowGamepage()
        {
            int incorrectscore = 0;
            HeaderHangman();
            ShowIncorrectScore(incorrectscore);
            string word = RandomWord();
            GuessWord(word.Length);
            ShowInput();
        }
        static void ShowInput() {
            Console.WriteLine("Input letter alphabet: ");
        }
        static void HeaderHangman()
        {
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("------------------");
        }
        static void ShowIncorrectScore(int incorrectScore)
        {
            Console.WriteLine("Incorrect Score: {0}", incorrectScore);
        }
        static void GuessWord(int CountCharacter) {
            for (int i = 0; i < CountCharacter; i++)
            {
                Console.Write("_" + " ");
            }
            Console.WriteLine();

        }
        static int RandomCodeWord(string[] words)
        {
            Random random = new Random();
            int resultRandom = random.Next(words.Length);
            return resultRandom;
        }
        static string RandomWord()
        {
            string[] words = new string[] { "tennis", "badminton", "football" };
            string wordchoose = words[RandomCodeWord(words)];
            Word word = new Word(wordchoose, CountCharacter(wordchoose), Character(wordchoose));
            return word.word;
        }
        static int CountCharacter(string word)
        {
            int numofchar = word.Length;
            return numofchar;
        }
        static char[] Character(string word)
        {
            char[] CharacterInword = word.ToCharArray();
            return CharacterInword;

        }
    }
}


