using System;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace AssignmentGrader
{
    public partial class Form1 : Form
    {
        #region Variables
        /// <summary>
        /// The amount of students.
        /// </summary>
        short students;

        /// <summary>
        /// The amount of assignments.
        /// </summary>
        short assignments;

        /// <summary>
        /// Student Index.
        /// </summary>
        short studentIndex = 0;

        /// <summary>
        /// An array of student names.
        /// </summary>
        string[] studentNames;

        /// <summary>
        /// 2D array for assignment scores.
        /// </summary>
        int[,] scores;

        #endregion

        public Form1()
        {
            InitializeComponent();
            this.Text = "Assignment Grader"; // Change Program Title
        }

        /// <summary>
        /// Set the amount of students and assignments.
        /// Checks for valid input then initializes arrays.
        /// Enable and Disable buttons then display default students and scores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Grab user input
                students = Int16.Parse(txtNumStudents.Text);
                assignments = Int16.Parse(txtNumAssignments.Text);

                // Throw errors if the amounts are out of acceptable ranges.
                if (students < 1 || students > 10)
                    throw new ArgumentOutOfRangeException("Student amount must be between 1 and 99");
                if (assignments < 1 || assignments > 99)
                    throw new ArgumentOutOfRangeException("Assignment amount must be between 1 and 99");

                // Initialize Arrays
                studentNames = new string[students];
                for (int i = 0; i < students; i++)
                    studentNames[i] = string.Concat("Student #", i + 1);

                scores = new int[students, assignments];
                for (int i = 0; i < students; i++)
                {
                    for (int j = 0; j < assignments; j++)
                        scores[i, j] = 0;
                }

                // Disable Score Changing
                btnSubmit.Enabled = false;
                btnSubmit.BackColor = Color.Gray;

                // Enable Everything Else
                btnIndFirst.Enabled = true;
                btnIndPrevious.Enabled = true;
                btnIndNext.Enabled = true;
                btnIndLast.Enabled = true;
                btnChangeName.Enabled = true;
                btnSaveScore.Enabled = true;
                btnDisplay.Enabled = true;

                btnIndFirst.BackColor = Color.White;
                btnIndPrevious.BackColor = Color.White;
                btnIndNext.BackColor = Color.White;
                btnIndLast.BackColor = Color.White;
                btnChangeName.BackColor = Color.White;
                btnSaveScore.BackColor = Color.White;
                btnDisplay.BackColor = Color.White;

                // Display First Student
                displayStudent();

                // Put Assignment List Together
                string tempList = "";
                for (int i = 0; i < assignments; i++)
                    tempList = string.Concat(tempList, "#", i + 1, "      ");
                tempList = string.Concat(tempList, "AVG      Grade");
                lblAssignmentList.Text = tempList;

                // Display Student List and Scores
                updateDisplay();
            }
            catch (Exception ex)
            {
                lblCountError.Text = ex.Message;
            }
        }

        /// <summary>
        /// Go to first student in index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIndFirst_Click(object sender, EventArgs e)
        {
            studentIndex = 0;
            displayStudent();
        }

        /// <summary>
        /// Go to previous student in index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIndPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                studentIndex--;
                displayStudent();
            }
            catch (IndexOutOfRangeException)
            {
                studentIndex = 0;
                displayStudent();
            }
        }

        /// <summary>
        /// Go to next student in index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIndNext_Click(object sender, EventArgs e)
        {
            try
            {
                studentIndex++;
                displayStudent();
            }
            catch (IndexOutOfRangeException)
            {
                studentIndex = (short)(students - 1);
                displayStudent();
            }
        }

        /// <summary>
        /// Go to last student in index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIndLast_Click(object sender, EventArgs e)
        {
            studentIndex = (short)(students - 1);
            displayStudent();
        }

        /// <summary>
        /// Display Current Student in Index
        /// </summary>
        private void displayStudent()
        {
            lblDisplayStudent.Text = studentNames[studentIndex];
        }

        /// <summary>
        /// Change Student Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeName_Click(object sender, EventArgs e)
        {
            studentNames[studentIndex] = txtNewName.Text;
            lblInfoStatus.Text = "Name Changed.";
        }

        /// <summary>
        /// Change Score on Selected Assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            try
            {
                int assignmentIndex = int.Parse(txtSelectAssignment.Text) - 1;
                int newScore = int.Parse(txtNewScore.Text);

                if (newScore < 0 || newScore > 100)
                    throw new ArgumentOutOfRangeException("Scores are worth anywhere between 0 to 100 points.");

                scores[studentIndex, assignmentIndex] = newScore;
                lblInfoStatus.Text = "Score Changed.";
            }
            catch (Exception ex)
            {
                lblInfoStatus.Text = ex.Message;
            }
        }

        /// <summary>
        /// Display Updated Student Names and Scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void updateDisplay()
        {
            string tempList = "";

            // Update Student Names
            foreach (string i in studentNames)
                tempList = string.Concat(tempList, i, "\n\n");

            lblStudentList.Text = tempList;

            // Update Scores
            tempList = "";
            for (int i = 0; i < students; i++)
            {
                char grade = 'E';
                int average = 0;

                for (int j = 0; j < assignments; j++)
                {
                    tempList = string.Concat(tempList, "  ", scores[i, j], "      ");
                    average += scores[i, j]; // Add scores up together
                }

                // Update Average
                average /= scores.GetLength(1);

                // Update Grade
                if (average >= 90)
                    grade = 'A';
                else if (average >= 80)
                    grade = 'B';
                else if (average >= 70)
                    grade = 'C';
                else if (average >= 60)
                    grade = 'D';

                // Display Results
                tempList = string.Concat(tempList, "      ", average, "           ", grade, "\n\n");
            }

            lblScoreList.Text = tempList;
        }

        /// <summary>
        /// Resets the program to default values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
