namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            int counter = -1;
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        counter++;
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                    


                }
            }
        }
    }
}
