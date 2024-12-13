int[] sophia = {90, 86, 87, 98, 100};

int[] andrew = {92, 89, 81, 96, 90};

int[] emma = {90, 85, 87, 98, 68};

int[] logan = {90, 95, 87, 88, 96};

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

int sophiaSum = sophia.Sum();
int andrewSum = andrew.Sum();
int emmaSum = emma.Sum();
int loganSum = logan.Sum();

decimal sophiaScores;
decimal andrewScores;
decimal emmaScores;
decimal loganScores;
decimal studentScores = 0;
string currentStudentLetterGrade = "";

sophiaScores = (decimal)sophiaSum / sophia.Length;
andrewScores = (decimal)andrewSum / andrew.Length;
emmaScores = (decimal)emmaSum / emma.Length;
loganScores = (decimal)loganSum / logan.Length;

Console.WriteLine("Student\t\tGrade\n");

foreach(string name in studentNames){
    if (name == "Sophia"){
        studentScores = sophiaScores;
    }
    else if (name == "Andrew"){
        studentScores = andrewScores;
    }
    else if (name == "Emma"){
        studentScores = emmaScores;
    }
    else if (name == "Logan"){
        studentScores = loganScores;
    }

    if (studentScores >= 97)
        currentStudentLetterGrade = "A+";

    else if (studentScores >= 93)
        currentStudentLetterGrade = "A";

    else if (studentScores >= 90)
        currentStudentLetterGrade = "A-";

    else if (studentScores >= 87)
        currentStudentLetterGrade = "B+";

    else if (studentScores >= 83)
        currentStudentLetterGrade = "B";

    else if (studentScores >= 80)
        currentStudentLetterGrade = "B-";

    else if (studentScores >= 77)
        currentStudentLetterGrade = "C+";

    else if (studentScores >= 73)
        currentStudentLetterGrade = "C";

    else if (studentScores >= 70)
        currentStudentLetterGrade = "C-";

    else if (studentScores >= 67)
        currentStudentLetterGrade = "D+";

    else if (studentScores >= 63)
        currentStudentLetterGrade = "D";

    else if (studentScores >= 60)
        currentStudentLetterGrade = "D-";

    Console.WriteLine($"{name}\t\t{studentScores}\t{currentStudentLetterGrade}");
}