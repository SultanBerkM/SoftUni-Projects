using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader firstFile = new StreamReader(firstInputFilePath);
            StreamReader secondFile = new StreamReader(secondInputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            using (firstFile)
            {
                using (secondFile)
                {
                    using (writer)
                    {
                        string lineFirstFile = firstFile.ReadLine();
                        string lineSecondFile = secondFile.ReadLine();
                        while (lineFirstFile != null || lineSecondFile != null)
                        {
                             
                            if (lineFirstFile != null)
                            {
                                writer.WriteLine(lineFirstFile);
                            }
                            if (lineSecondFile != null)
                            {
                                writer.WriteLine(lineSecondFile);
                            }
                            lineFirstFile = firstFile.ReadLine();
                            lineSecondFile = secondFile.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
