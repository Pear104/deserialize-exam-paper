using QuestionLib;

namespace ConsoleApp
{
    internal class Helper
    {
        public static void printMetadata(SubmitPaper submitPaper)
        {
            Console.WriteLine($"LoginId: {submitPaper.LoginId}");
            Console.WriteLine($"TimeLeft: {submitPaper.TimeLeft}");
            Console.WriteLine($"IndexFill: {submitPaper.IndexFill}");
            Console.WriteLine($"IndexReading: {submitPaper.IndexReading}");
            Console.WriteLine($"IndexG: {submitPaper.IndexG}");
            Console.WriteLine($"IndexIndiM: {submitPaper.IndexIndiM}");
            Console.WriteLine($"IndexMatch: {submitPaper.IndexMatch}");
            Console.WriteLine($"Finish: {submitPaper.Finish}");
            Console.WriteLine($"TabIndex: {submitPaper.TabIndex}");
            Console.WriteLine($"SubmitTime: {submitPaper.SubmitTime}");

            Console.WriteLine("\n=========================Paper========================\n");


            Console.WriteLine($"IsShuffleReading: {submitPaper.SPaper.IsShuffleReading}");
            Console.WriteLine($"IsShuffleGrammer: {submitPaper.SPaper.IsShuffleGrammer}");
            Console.WriteLine($"IsShuffleMatch: {submitPaper.SPaper.IsShuffleMatch}");
            Console.WriteLine($"IsShuffleIndicateMistake: {submitPaper.SPaper.IsShuffleIndicateMistake}");
            Console.WriteLine($"IsShuffleFillBlank: {submitPaper.SPaper.IsShuffleFillBlank}");

            Console.WriteLine($"QD: {submitPaper.SPaper.QD}");

            Console.WriteLine($"Duration: {submitPaper.SPaper.Duration}");
            Console.WriteLine($"ExamCode: {submitPaper.SPaper.ExamCode}");
            Console.WriteLine($"Mark: {submitPaper.SPaper.Mark}");
            Console.WriteLine($"NoOfQuestion: {submitPaper.SPaper.NoOfQuestion}");

            Console.WriteLine($"ReadingQuestions: {submitPaper.SPaper.ReadingQuestions.Cast<object>()}");
            Console.WriteLine($"GrammarQuestions: {string.Join(", ", submitPaper.SPaper.GrammarQuestions.Cast<object>())}");
            Console.WriteLine($"MatchQuestions: {string.Join(", ", submitPaper.SPaper.MatchQuestions.Cast<object>())}");
            Console.WriteLine($"IndicateMQuestions: {string.Join(", ", submitPaper.SPaper.IndicateMQuestions.Cast<object>())}");
            Console.WriteLine($"FillBlankQuestions: {string.Join(", ", submitPaper.SPaper.FillBlankQuestions.Cast<object>())}");

            Console.WriteLine($"EssayQuestion: {submitPaper.SPaper.EssayQuestion}");

            Console.WriteLine($"StudentGuide: {submitPaper.SPaper.StudentGuide}");
            Console.WriteLine($"ListenCode: {submitPaper.SPaper.ListenCode}");
            Console.WriteLine($"Password: {submitPaper.SPaper.Password}");

            Console.WriteLine($"TestType: {submitPaper.SPaper.TestType}");
            Console.WriteLine($"ImgPaper: {submitPaper.SPaper.ImgPaper}");

            //Console.WriteLine($"ListAudio: {string.Join(", ", submitPaper.SPaper.ListAudio.Cast<object>())}");

            //Console.WriteLine($"OneSecSilence: {BitConverter.ToString(submitPaper.SPaper.OneSecSilence)}");
            Console.WriteLine($"AudioHeadPadding: {submitPaper.SPaper.AudioHeadPadding}");
        }

    }
}
