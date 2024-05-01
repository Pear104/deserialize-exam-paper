using QuestionLib;
using QuestionLib.Entity;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
            var filePath = Path.Combine(projectRoot, "sample", "vynmvse170255.dat");
            SubmitPaper submitPaper = QuestionHelper.LoadSubmitPaper(filePath);
            if (submitPaper == null)
            {
                Console.WriteLine("null");
            }
            Helper.printMetadata(submitPaper);
            foreach (Question q in submitPaper.SPaper.GrammarQuestions)
            {
                Console.WriteLine("==========");
                Console.WriteLine($"Question ID: {q.QID}");
                foreach (QuestionAnswer qa in q.QuestionAnswers)
                {
                    Console.WriteLine($"Answer ID: {qa.QAID}, Selected: {qa.Selected}");
                }
            }

            //Console.WriteLine($"QBID {q.QBID}");
            //Console.WriteLine($"PID {q.PID}");
            //Console.WriteLine($"Lock {q.Lock}");
            //Console.WriteLine($"ImageData {q.ImageData}");
            //Console.WriteLine($"Text {q.Text}");
            //Console.WriteLine($"ChapterId {q.ChapterId}");
            //Console.WriteLine($"Question Answer: {string.Join(", ", q.QuestionAnswers.Cast<QuestionAnswer>())}");
            //Console.WriteLine($"Question Answer 1 {((QuestionAnswer)q.QuestionAnswers[0]).}");
            //Console.WriteLine($"Question Answer 2 {((QuestionAnswer)q.QuestionAnswers[0]).QID}");
            //Console.WriteLine($"Question Answer 3 {((QuestionAnswer)q.QuestionAnswers[0]).QBID}");
            //Console.WriteLine($"Question Answer 4 {((QuestionAnswer)q.QuestionAnswers[0]).QAID}");
            //Console.WriteLine(submitPaper.LoginId);
        }
    }
}
