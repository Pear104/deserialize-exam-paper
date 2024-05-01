using QuestionLib;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
            var filePath = Path.Combine(projectRoot, "dat", "yentthse170121.dat");
            SubmitPaper submitPaper = QuestionHelper.LoadSubmitPaper(filePath);

            Helper.printMetadata(submitPaper);
            // var test = (Passage)submitPaper.SPaper.ReadingQuestions[0];
            // Console.WriteLine($"PID {test.PID}");
            // Console.WriteLine($"CourseId {test.CourseId}");
            // Console.WriteLine($"ChapterId {test.ChapterId}");
            // Console.WriteLine($"Text {test.Text}");
            // Console.WriteLine($"PassageQuestions {test.PassageQuestions}");
            // Console.WriteLine($"QBID {test.QBID}");
        }
    }
}
