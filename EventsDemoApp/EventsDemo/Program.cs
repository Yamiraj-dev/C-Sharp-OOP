namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel computerScience = new CollegeClassModel("Computer Science", 4);
            CollegeClassModel statistics = new CollegeClassModel("Statistics and Data", 2);

            computerScience.EnrollmentFull += CollegeClass_EnrollmentFull; // this adds a listener, += because we can add multiple listeners, so not equals or it overwrites the previous event. 

            computerScience.SignUpStudent("Mus Gonzales").PrintToConsole();
            computerScience.SignUpStudent("Amirah Jaafar").PrintToConsole();
            computerScience.SignUpStudent("Jaysea Cuares").PrintToConsole();
            computerScience.SignUpStudent("Pia Sulaiman").PrintToConsole();
            computerScience.SignUpStudent("Ambrosine Wani").PrintToConsole();
            Console.WriteLine();

            statistics.EnrollmentFull += CollegeClass_EnrollmentFull;

            statistics.SignUpStudent("Juno Raymond").PrintToConsole();
            statistics.SignUpStudent("SmokeU Bare").PrintToConsole();
            statistics.SignUpStudent("Momo Hani").PrintToConsole();

            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object? sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender;

            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle}: Full");
            Console.WriteLine();
        }
    }

    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CollegeClassModel
    {
        public event EventHandler<string> EnrollmentFull; // create the event

        private List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; private set; }

        public CollegeClassModel(string title, int maximumStudents)
        {
            CourseTitle = title;
            MaximumStudents = maximumStudents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = "";

            if (enrolledStudents.Count < MaximumStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} was enrolled in {CourseTitle}";
                // check to see if there is max number of students
                if (enrolledStudents.Count >= MaximumStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is full."); // call the event, this refers to the sender
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} was added to the waiting list for {CourseTitle}";
            }

            return output;
        }
    }
}