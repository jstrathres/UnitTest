using BasicUnitTest;

var gradeCalculator = new GradeCalculator();

Console.WriteLine("Enter Your Score Here:");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeCalculator(percentage);

//Console.WriteLine(gradeCalculator.GetGradeCalcutor(grade));
Console.WriteLine($"Student Grade : {grade}");