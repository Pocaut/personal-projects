//Updated 2024.12.16, left old code at the bottom for comparison.

string studentName = "Sophia Johnson";
string[] courseNames = {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"};

int i = 0;

int[] courseCredits = {3, 3, 4, 4, 3};

int[] courseGrade = {4, 3, 3, 3, 4};

int totalCreditHours = 0;
foreach (int credit in courseCredits){
    totalCreditHours += credit;
}

int totalGradePoints = 0;

for (i = 0; i < courseCredits.Length; i++)
{
    totalGradePoints += courseCredits[i] * courseGrade[i];
}

decimal gradePointAverage = (decimal)totalGradePoints/totalCreditHours;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine ("Course \t\t\t\tGrade\tCredit");
for (i = 0; i < courseCredits.Length; i++)
{
Console.WriteLine($"{courseNames[i]} \t\t{courseGrade[i]} \t\t{courseCredits[i]}");
}
Console.WriteLine($"\nFinal GPA: \t\t\t{gradePointAverage:F2}");

/*
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int gradeA = 4;
int gradeB = 3;

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints/totalCreditHours;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine ("Course \t\t\t\tGrade\tCredit");
Console.WriteLine($"{course1Name} \t\t{course1Grade} \t\t{course1Credit}");
Console.WriteLine($"{course2Name} \t\t{course2Grade} \t\t{course2Credit}");
Console.WriteLine($"{course3Name} \t\t{course3Grade} \t\t{course3Credit}");
Console.WriteLine($"{course4Name}  {course4Grade} \t\t{course4Credit}");
Console.WriteLine($"{course5Name} \t\t{course5Grade} \t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA: \t\t\t{gradePointAverage:F2}");
*/
