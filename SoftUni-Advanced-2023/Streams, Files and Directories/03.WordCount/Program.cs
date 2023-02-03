using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {

            StreamReader words = new StreamReader(wordsFilePath);
            StreamReader textReader = new StreamReader(textFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (words)
            {
                using (textReader)
                {
                    using (writer)
                    {
                        string[] wordsSepareted = words.ReadToEnd().Split();

                        SortedDictionary<string, int> countingWords = new SortedDictionary<string, int>();
                        for (int i = 0; i < wordsSepareted.Length; i++)
                        {
                            if (!countingWords.ContainsKey(wordsSepareted[i]))
                            {
                                countingWords.Add(wordsSepareted[i], 0);
                            }
                        }

                        string line = textReader.ReadLine();
                        while (line != null)
                        {
                            string[] lineArr = line.Split();
                            
                            for (int i = 0; i < lineArr.Length; i++)
                            {
                                string current = lineArr[i];
                                if (current[0] == '-')
                                {
                                    current = current.Remove(0, 1);
                                    if (current[current.Length - 1] == ',')
                                    {
                                        current = current.Remove(current.Length - 1, 1);
                                    }
                                }
                                else if(current[current.Length-1] == '.')
                                {
                                    current = current.Remove(current.Length - 1, 1);
                                }
                                else if (current[current.Length - 1] == ',')
                                {
                                    current = current.Remove(current.Length - 1, 1);
                                }

                                if (countingWords.ContainsKey(current.ToLower()))
                                {
                                    countingWords[current.ToLower()]++;
                                }
                            }
                            line = textReader.ReadLine();
                        }
                        var ordered = countingWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        foreach (var item in ordered)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }

                    }
                }

            }
        }
    }
}

