namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int punctoationCnt = 0;
            int letterCnt = 0;
            int counter = 1;
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (char.IsPunctuation(line[i]))
                            {
                                punctoationCnt++;
                            }
                            else if (char.IsLetter(line[i]))
                            {
                                letterCnt++;
                            }
                        }
                        writer.WriteLine($"Line {counter} {line} ({letterCnt})({punctoationCnt})");
                        punctoationCnt = 0;
                        letterCnt = 0;
                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
