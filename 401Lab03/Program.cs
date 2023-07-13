﻿using System;

namespace Lab03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Challenge 1");
            Challenge1();

            Console.WriteLine("Challenge 2");
            Challenge2();

            Console.WriteLine("Challenge 3");
            Challenge3();

            Console.WriteLine("Challenge 4");
            int[] array4 = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int result = Challenge4(array4);
            Console.WriteLine("Input: " + array4);
            Console.WriteLine("Output: " + result);

            Console.WriteLine("Challenge 5");
            int[] array5 = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            int result5 = Challenge5(array5);
            Console.WriteLine("Input: " + array5);
            Console.WriteLine("Output: " + result5);

            Console.WriteLine("Challenge 6");
            Challenge6();

            Console.WriteLine("Challenge 7");
            Challenge7();

            Console.WriteLine("Challenge 8");
            Challenge8();

            Console.WriteLine("Challenge 9");
            string sentence9 = "This is a sentence about important things";
            string[] result9 = Challenge9(sentence9);
            Console.WriteLine("Output:");
            foreach (string word in result9)
            {
                Console.WriteLine(word);
            }
        }

        static void Challenge1()
        {
            Console.WriteLine("Please enter 3 numbers (space out each number):");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            if (numbers.Length < 3)
            {
                Console.WriteLine("Not enough numbers entered.");
                return;
            }

            int product = 1;
            for (int i = 0; i < 3; i++)
            {
                if (!int.TryParse(numbers[i], out int num))
                    num = 1;
                product *= num;
            }

            Console.WriteLine("The product of these 3 numbers is: " + product);
        }
        static void Challenge2()
        {
            int count;

            do
            {
                Console.WriteLine("Please enter a number between 2-10:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out count))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (count < 2 || count > 10)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 2-10.");
                    continue;
                }

                break;
            } while (true);

            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                int number;

                do
                {
                    Console.WriteLine($"{i} of {count} - Enter a number:");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out number))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    if (number < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a non-negative number.");
                        continue;
                    }

                    break;
                } while (true);

                sum += number;
            }

            double average = (double)sum / count;
            Console.WriteLine("The average of these " + count + " numbers is: " + average);
        }

        static void Challenge3()
        {
            Console.WriteLine("       *     ");
            Console.WriteLine("      **     ");
            Console.WriteLine("     ***     ");
            Console.WriteLine("    *****    ");
            Console.WriteLine("  *********  ");
            Console.WriteLine("*************");
            Console.WriteLine("  *********  ");
            Console.WriteLine("    *****    ");
            Console.WriteLine("     ***     ");
            Console.WriteLine("      **     ");
            Console.WriteLine("      *      ");
        }

        static int Challenge4(int[] numbers)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (countMap.ContainsKey(number))
                    countMap[number]++;
                else
                    countMap[number] = 1;
            }

            int maxCount = 0;
            int mostFrequentNumber = numbers[0];

            foreach (KeyValuePair<int, int> kvp in countMap)
            {
                if (kvp.Value > maxCount)
                {
                    maxCount = kvp.Value;
                    mostFrequentNumber = kvp.Key;
                }
            }

            return mostFrequentNumber;
        }

        static int Challenge5(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("The array is null or empty.");
                return int.MinValue;
            }

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            return max;
        }

        static void Challenge6()
        {
            Console.WriteLine("Please enter a word:");

            string word = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter("words.txt", true))
            {
                writer.WriteLine(word);
                Console.WriteLine("Word successfully saved to words.txt.");
            }
        }

        static void Challenge7()
        {
            try
            {
                using (StreamReader reader = new StreamReader("words.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The words.txt file does not exist.");
            }
        }

        static void Challenge8()
        {
            try
            {
                Console.WriteLine("Removing a word from words.txt...");

                string[] lines = File.ReadAllLines("words.txt");
                if (lines.Length == 0)
                {
                    Console.WriteLine("The words.txt file is empty.");
                    return;
                }

                // Remove a word from the lines array (e.g., remove the first word)
                string[] newLines = new string[lines.Length - 1];
                Array.Copy(lines, 1, newLines, 0, lines.Length - 1);

                File.WriteAllLines("words.txt", newLines);

                Console.WriteLine("Word removed and file updated successfully.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The words.txt file does not exist.");
            }
        }

        static string[] Challenge9(string sentence)
        {
            string[] words = sentence.Split(' ');
            string[] result = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int wordLength = word.Length;
                result[i] = $"{word}: {wordLength}";
            }

            return result;
        }




    }
}