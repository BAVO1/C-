using System;
namespace Oop
{
    class Student
    {
        private string name;
        private int studentNumber;
        private string Class;
        private string major;
        public Student(string name, int studentNumber, string Class, string major)
        {
            this.studentNumber = studentNumber;
            this.name = name;
            this.Class = Class;
            this.major = major;
        }
        public virtual void OutPut()
        {
            Console.WriteLine(" Name :  " + name + "  StudentNumber : " + studentNumber + "  Class : " + Class + "   Major : " + major);
        }
    }
    class Course 
    { 
        private string courseName;
        public string courseNumber;
        private int creditHours;
        private string department;
        public Course(string courseName, string courseNumber, int creditHours, string department) 
        {
            this.courseNumber = courseNumber;
            this.creditHours = creditHours;
            this.department = department;
        }
        public virtual void OutPut()
        {
            Console.WriteLine(" CourseName : " + courseName + "  CourseNumber : " + courseNumber + "  CreditHours : " + creditHours + "  Department : " + department);
        }
    }
    class Section 
    {
        private Course courseNumber;
        private int sectionIdentifier;
        private string semester;
        private int year;
        private string instructor;
        public Section(int sectionIdentifier, string courseNumber, string semester, int year, string instructor)
        {    
            this.semester = semester;
            this.year = year;
            this.instructor = instructor;
            this.sectionIdentifier = sectionIdentifier;
        }
        public  void OutPut()
        {
            Console.WriteLine("  SectionIdentifier : " + sectionIdentifier + "   CourseNumber : " + courseNumber + "  Semester : " + semester + "  Year :  " + year + "  Instructor : " + instructor);
        }
    }
    class GradeReport
    {
        private string grade;
        private Student studentNumber;
        private Course courseNumber;
       public GradeReport(Student studentNumber,int sectionIdentifier,string grade)
       {
            this.grade = grade;
       }
        public void OutPut()
        {
            Console.WriteLine("  CourseNumber : "+courseNumber+ "  Grade : " + grade);
        }
    }
    class Prerequisite 
    {
        private string prerequisiteNumber;
        private Course courseNumber;
        public Prerequisite(string prerequisiteNumber, Course courseNumber)
        {
            this.prerequisiteNumber = prerequisiteNumber;
            this.courseNumber = courseNumber;
        }
    }
    class Tester
    {
        static void Main()
        {
            Student a = new Student("Smith", 17, "1", "CS");
            Student b = new Student("Brown", 8, "2", "CS");
            Course a1 = new Course("Intro to Computer Science", "CS1310", 4, "CS");
            Course a2 = new Course("Data Structures", "CS3320", 4, "CS");
            Course a3 = new Course("Discrete", "MATH2410", 3, "MATH");
            Course a4 = new Course("Database", "CS3380", 3, "CS");
            Section a5 = new Section(85, "MATH2410", "FALL", 7, "King");
            Section a6 = new Section(92, "CS1310", "FALL", 7, "KAnderson");
            Section a7 = new Section(102, "CS3320", "Spring",8, "Knuth");
            Section a8 = new Section(112, "MATH2410", "FALL", 8, "Chang");
            Section a9 = new Section(119, "CS1310", "FALL", 8, "Anderson");
            Section a10 = new Section(135, "CS3380", "FALL", 8, "Stone");
            GradeReport a11 = new GradeReport(b, 112, "B");
            GradeReport a12 = new GradeReport(b, 119, "C");
            GradeReport a13 = new GradeReport(a, 85, "A");
            GradeReport a14 = new GradeReport(a, 92, "A");
            GradeReport a15 = new GradeReport(a, 102, "B");
            GradeReport a16 = new GradeReport(a, 135, "A");
            Prerequisite a17 = new Prerequisite("CS3380", a2);
            Prerequisite a18 = new Prerequisite("CS3380", a3);
            Prerequisite a19 = new Prerequisite("CS3380", a1);
        }
    }
}