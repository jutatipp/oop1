using Grade_point;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        int high = 0;
        int low = 0;
        string[] arrName = new string[10000];
        string[] arrID = new string[10000];
        int[] arrScore = new int[10000];
        List<Student> listStudent = new List<Student>();
        int SUM = 0;
        int gradeA = 0;
        int gradeBplus = 0;
        int gradeB = 0;
        int gradeCplus = 0;
        int gradeC = 0;
        int gradeDplus = 0;
        int gradeD = 0;
        int F = 0;
        string Grade;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inputName = name.Text;
            string inputID = textID.Text;
            string inputScore = (score.Text);
            Student student = new Student();
            try
            {
                student.name = inputID;
                student.studentid = inputID;
                student.score = double.Parse(inputScore);
                double.Truncate( inputScore);

                listStudent.Add(student);
                findMaxScore();


                /*arrID[arrayIndex] = inputID;
                arrName[arrayIndex] = inputName;
                arrScore[arrayIndex] = inputScore;
                arrayIndex++;

                score.Text = inputScore.ToString();

                if (inputScore > high)
                {
                    high = inputScore;
                    textBox13.Text = inputID;
                    textBox15.Text = inputName;
                    textBox17.Text = inputScore.ToString();
                    low = high;
                }

                if (inputScore < low)
                {
                    low = inputScore;
                    textBox14.Text = inputID;
                    textBox16.Text = inputName;
                    textBox18.Text = inputScore.ToString();
                }

                int SUM = high + low;
                double SUM2 = SUM / 2;
                string SUM3 = SUM2.ToString();
                textBox19.Text = SUM3;

                if ((inputScore >= 80) && (inputScore <= 100))
                {
                    Grade = "A";
                    gradeA++;
                }
                if ((inputScore >= 75) && (inputScore < 79))
                {
                    Grade = "B+";
                    gradeBplus++;
                }
                if ((inputScore >= 70) && (inputScore < 74))
                {
                    Grade = "B";
                    gradeB++;
                }
                if ((inputScore >= 65) && (inputScore < 69))
                {
                    Grade = "C+";
                    gradeCplus++;
                }
                if ((inputScore >= 60) && (inputScore < 64))
                {
                    Grade = "C";
                    gradeC++;
                }
                if ((inputScore >= 55) && (inputScore < 59))
                {
                    Grade = "D+";
                    gradeDplus++;
                }
                if ((inputScore >= 50) && (inputScore < 54))
                {
                    Grade = "D";
                    gradeD++;
                }
                else
                {
                    Grade = "F";
                    F++;
                }

                double v = (gradeA * 4.0) + (gradeBplus * 3.5) + (gradeB * 3.0) + (gradeCplus * 2.5) + (gradeC * 2.0) + (gradeDplus * 1.5) + (gradeD * 1.0);
                int GPA = (int)v;
                double GPA2 = GPA / arrayIndex;
                string GPA3 = GPA2.ToString();
                textBox12.Text = GPA3;

                textBox4.Text = gradeA.ToString();
                textBox5.Text = gradeBplus.ToString();
                textBox6.Text = gradeB.ToString();
                textBox7.Text = gradeCplus.ToString();
                textBox8.Text = gradeC.ToString();
                textBox9.Text = gradeDplus.ToString();
                textBox10.Text = gradeD.ToString();
                textBox11.Text = F.ToString();*/

             }
        void findMaxScore()
        {
            double maxScore = 0;
            foreach (Student student in listStudent)
                {
                if (student.score > maxScore)
                {

                }
            }
        }
            

        }
    }
}
