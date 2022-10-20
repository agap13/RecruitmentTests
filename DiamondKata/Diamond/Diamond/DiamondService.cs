namespace Diamond
{
    public class DiamondService
    {
        private static readonly char[] AlphabetLetters = new char[26] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z' };

        public char Letter { get; set; }
        public DiamondService(char letter)
        {
            Letter = letter;
        }

        public string[] Create()
        {
            int letter_number = GetPositionOfLetterInAlphabet(Letter);
            if (letter_number == -1)
                return null;

            string[] diamond = new string[letter_number+1];
            for (int i = 0; i <= letter_number; i++)
            {
                //add initial spaces
                for (int j = 0; j < letter_number - i; j++)
                {
                    diamond[i] += "_";
                }

                //add letter (first time)
                diamond[i] += AlphabetLetters[i];

                //add space between letters
                if (AlphabetLetters[i] != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        diamond[i] += "_";
                    }
                    //add letter (second time)
                    diamond[i] += AlphabetLetters[i];
                }
                for (int j = letter_number - i; j > 0; j--)
                {
                    diamond[i] += "_";
                }
            }
            return diamond;
        }

        public void PrintDiamond()
        {
            int letter_number = GetPositionOfLetterInAlphabet(Letter);
            if (letter_number == -1)
                return;
            var diamond = Create();
            for (int i = 0; i <= letter_number; i++)
            {
                // Print the first part of the diamond as it's composing.
                Console.WriteLine(diamond[i]);
            }

            for (int i = letter_number - 1; i >= 0; i--)
            {
                // Print the second part of the diamond
                Console.WriteLine(diamond[i]);
            }
        }

        private int GetPositionOfLetterInAlphabet(char letter)
        {
            for (int i = 0; i < AlphabetLetters.Length; i++)
            {
                if (letter == AlphabetLetters[i])
                    return i;
            }
            return -1;
        }
    }
}
