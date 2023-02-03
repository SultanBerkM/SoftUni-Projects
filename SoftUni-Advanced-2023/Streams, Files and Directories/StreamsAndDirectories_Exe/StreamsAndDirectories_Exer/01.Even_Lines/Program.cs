namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            int cnt = 0;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                
                List<string> output = new List<string>();
                
                while (line != null)
                {
                    string editedText = string.Empty;
                    string empty = string.Empty;
                    if (cnt %2==0)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == '-')
                                editedText += '@';
                            else if (line[i] == ',')
                                editedText += '@';
                            else if (line[i] == '.')
                                editedText += '@';
                            else if (line[i] == '!')
                                editedText += '@';
                            else if (line[i] == '?')
                                editedText += '@';
                            else
                                editedText += line[i];
                        }
                        string[] wordEditedText = editedText.Split();
                        for (int i = wordEditedText.Length - 1; i >= 0; i--)
                        {
                            empty += wordEditedText[i] + " ";
                        }
                        empty = empty.Trim();
                        output.Add(empty);
                        
                    }
                    cnt++;
                    line = reader.ReadLine();

                }
                string realOutput = string.Empty;
                foreach (var item in output)
                {
                    realOutput += item+ " \n";
                                        
                }
                return realOutput;
            }


        }
    }
}

