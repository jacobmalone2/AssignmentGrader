namespace AssignmentGrader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblScoreList = new Label();
            lblStudentList = new Label();
            lblAssignmentList = new Label();
            lblStudent = new Label();
            gbCounts = new GroupBox();
            btnReset = new Button();
            btnSubmit = new Button();
            lblCountError = new Label();
            txtNumAssignments = new TextBox();
            txtNumStudents = new TextBox();
            lblNumAssignments = new Label();
            lblNumStudents = new Label();
            gbNavigation = new GroupBox();
            btnIndLast = new Button();
            btnIndNext = new Button();
            btnIndPrevious = new Button();
            btnIndFirst = new Button();
            groupBox1 = new GroupBox();
            lblInfoStatus = new Label();
            btnSaveScore = new Button();
            txtNewScore = new TextBox();
            txtSelectAssignment = new TextBox();
            txtNewName = new TextBox();
            btnChangeName = new Button();
            lblScoreInput = new Label();
            lblAssignmentNumber = new Label();
            lblDisplayStudent = new Label();
            btnDisplay = new Button();
            panel1.SuspendLayout();
            gbCounts.SuspendLayout();
            gbNavigation.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblScoreList);
            panel1.Controls.Add(lblStudentList);
            panel1.Controls.Add(lblAssignmentList);
            panel1.Controls.Add(lblStudent);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 431);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 153);
            panel1.TabIndex = 0;
            // 
            // lblScoreList
            // 
            lblScoreList.AutoSize = true;
            lblScoreList.Location = new Point(178, 35);
            lblScoreList.Name = "lblScoreList";
            lblScoreList.Size = new Size(29, 15);
            lblScoreList.TabIndex = 2;
            lblScoreList.Text = "N/A";
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Location = new Point(10, 35);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(29, 15);
            lblStudentList.TabIndex = 1;
            lblStudentList.Text = "N/A";
            // 
            // lblAssignmentList
            // 
            lblAssignmentList.AutoSize = true;
            lblAssignmentList.Location = new Point(178, 10);
            lblAssignmentList.Name = "lblAssignmentList";
            lblAssignmentList.Size = new Size(128, 15);
            lblAssignmentList.TabIndex = 0;
            lblAssignmentList.Text = "#N/A       AVG      Grade";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(10, 10);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(48, 15);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Student";
            // 
            // gbCounts
            // 
            gbCounts.Controls.Add(btnReset);
            gbCounts.Controls.Add(btnSubmit);
            gbCounts.Controls.Add(lblCountError);
            gbCounts.Controls.Add(txtNumAssignments);
            gbCounts.Controls.Add(txtNumStudents);
            gbCounts.Controls.Add(lblNumAssignments);
            gbCounts.Controls.Add(lblNumStudents);
            gbCounts.Location = new Point(12, 12);
            gbCounts.Name = "gbCounts";
            gbCounts.Size = new Size(716, 128);
            gbCounts.TabIndex = 1;
            gbCounts.TabStop = false;
            gbCounts.Text = "Counts";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(648, 17);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(62, 48);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset\r\nScores\r\n";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(648, 71);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(62, 48);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit\r\nCounts";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblCountError
            // 
            lblCountError.AutoSize = true;
            lblCountError.Location = new Point(6, 88);
            lblCountError.Name = "lblCountError";
            lblCountError.Size = new Size(96, 15);
            lblCountError.TabIndex = 4;
            lblCountError.Text = "No Errors Found.";
            // 
            // txtNumAssignments
            // 
            txtNumAssignments.Location = new Point(152, 47);
            txtNumAssignments.Name = "txtNumAssignments";
            txtNumAssignments.Size = new Size(100, 23);
            txtNumAssignments.TabIndex = 3;
            // 
            // txtNumStudents
            // 
            txtNumStudents.Location = new Point(152, 17);
            txtNumStudents.Name = "txtNumStudents";
            txtNumStudents.Size = new Size(100, 23);
            txtNumStudents.TabIndex = 2;
            // 
            // lblNumAssignments
            // 
            lblNumAssignments.AutoSize = true;
            lblNumAssignments.Location = new Point(10, 50);
            lblNumAssignments.Name = "lblNumAssignments";
            lblNumAssignments.Size = new Size(136, 15);
            lblNumAssignments.TabIndex = 1;
            lblNumAssignments.Text = "Number of Assignments";
            // 
            // lblNumStudents
            // 
            lblNumStudents.AutoSize = true;
            lblNumStudents.Location = new Point(10, 20);
            lblNumStudents.Name = "lblNumStudents";
            lblNumStudents.Size = new Size(114, 15);
            lblNumStudents.TabIndex = 0;
            lblNumStudents.Text = "Number of Students";
            // 
            // gbNavigation
            // 
            gbNavigation.Controls.Add(btnIndLast);
            gbNavigation.Controls.Add(btnIndNext);
            gbNavigation.Controls.Add(btnIndPrevious);
            gbNavigation.Controls.Add(btnIndFirst);
            gbNavigation.Location = new Point(12, 155);
            gbNavigation.Name = "gbNavigation";
            gbNavigation.Size = new Size(330, 58);
            gbNavigation.TabIndex = 2;
            gbNavigation.TabStop = false;
            gbNavigation.Text = "Navigation";
            // 
            // btnIndLast
            // 
            btnIndLast.BackColor = Color.Gray;
            btnIndLast.Enabled = false;
            btnIndLast.Location = new Point(249, 22);
            btnIndLast.Name = "btnIndLast";
            btnIndLast.Size = new Size(75, 23);
            btnIndLast.TabIndex = 3;
            btnIndLast.Text = "Last";
            btnIndLast.UseVisualStyleBackColor = false;
            btnIndLast.Click += btnIndLast_Click;
            // 
            // btnIndNext
            // 
            btnIndNext.BackColor = Color.Gray;
            btnIndNext.Enabled = false;
            btnIndNext.Location = new Point(168, 22);
            btnIndNext.Name = "btnIndNext";
            btnIndNext.Size = new Size(75, 23);
            btnIndNext.TabIndex = 3;
            btnIndNext.Text = "Next";
            btnIndNext.UseVisualStyleBackColor = false;
            btnIndNext.Click += btnIndNext_Click;
            // 
            // btnIndPrevious
            // 
            btnIndPrevious.BackColor = Color.Gray;
            btnIndPrevious.Enabled = false;
            btnIndPrevious.Location = new Point(87, 22);
            btnIndPrevious.Name = "btnIndPrevious";
            btnIndPrevious.Size = new Size(75, 23);
            btnIndPrevious.TabIndex = 3;
            btnIndPrevious.Text = "Previous";
            btnIndPrevious.UseVisualStyleBackColor = false;
            btnIndPrevious.Click += btnIndPrevious_Click;
            // 
            // btnIndFirst
            // 
            btnIndFirst.BackColor = Color.Gray;
            btnIndFirst.Enabled = false;
            btnIndFirst.Location = new Point(6, 22);
            btnIndFirst.Name = "btnIndFirst";
            btnIndFirst.Size = new Size(75, 23);
            btnIndFirst.TabIndex = 0;
            btnIndFirst.Text = "First";
            btnIndFirst.UseVisualStyleBackColor = false;
            btnIndFirst.Click += btnIndFirst_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblInfoStatus);
            groupBox1.Controls.Add(btnSaveScore);
            groupBox1.Controls.Add(txtNewScore);
            groupBox1.Controls.Add(txtSelectAssignment);
            groupBox1.Controls.Add(txtNewName);
            groupBox1.Controls.Add(btnChangeName);
            groupBox1.Controls.Add(lblScoreInput);
            groupBox1.Controls.Add(lblAssignmentNumber);
            groupBox1.Controls.Add(lblDisplayStudent);
            groupBox1.Location = new Point(12, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 149);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // lblInfoStatus
            // 
            lblInfoStatus.AutoSize = true;
            lblInfoStatus.Location = new Point(10, 118);
            lblInfoStatus.Name = "lblInfoStatus";
            lblInfoStatus.Size = new Size(135, 15);
            lblInfoStatus.TabIndex = 6;
            lblInfoStatus.Text = "No Changes Attempted.";
            // 
            // btnSaveScore
            // 
            btnSaveScore.BackColor = Color.Gray;
            btnSaveScore.Enabled = false;
            btnSaveScore.Location = new Point(295, 75);
            btnSaveScore.Name = "btnSaveScore";
            btnSaveScore.Size = new Size(104, 23);
            btnSaveScore.TabIndex = 7;
            btnSaveScore.Text = "Save Score";
            btnSaveScore.UseVisualStyleBackColor = false;
            btnSaveScore.Click += btnSaveScore_Click;
            // 
            // txtNewScore
            // 
            txtNewScore.Location = new Point(168, 87);
            txtNewScore.Name = "txtNewScore";
            txtNewScore.Size = new Size(100, 23);
            txtNewScore.TabIndex = 6;
            // 
            // txtSelectAssignment
            // 
            txtSelectAssignment.Location = new Point(168, 58);
            txtSelectAssignment.Name = "txtSelectAssignment";
            txtSelectAssignment.Size = new Size(100, 23);
            txtSelectAssignment.TabIndex = 5;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(168, 29);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(100, 23);
            txtNewName.TabIndex = 4;
            // 
            // btnChangeName
            // 
            btnChangeName.BackColor = Color.Gray;
            btnChangeName.Enabled = false;
            btnChangeName.Location = new Point(295, 29);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(104, 23);
            btnChangeName.TabIndex = 3;
            btnChangeName.Text = "Change Name";
            btnChangeName.UseVisualStyleBackColor = false;
            btnChangeName.Click += btnChangeName_Click;
            // 
            // lblScoreInput
            // 
            lblScoreInput.AutoSize = true;
            lblScoreInput.Location = new Point(10, 90);
            lblScoreInput.Name = "lblScoreInput";
            lblScoreInput.Size = new Size(42, 15);
            lblScoreInput.TabIndex = 2;
            lblScoreInput.Text = "Score: ";
            // 
            // lblAssignmentNumber
            // 
            lblAssignmentNumber.AutoSize = true;
            lblAssignmentNumber.Location = new Point(10, 61);
            lblAssignmentNumber.Name = "lblAssignmentNumber";
            lblAssignmentNumber.Size = new Size(123, 15);
            lblAssignmentNumber.TabIndex = 1;
            lblAssignmentNumber.Text = "Assignment Number: ";
            // 
            // lblDisplayStudent
            // 
            lblDisplayStudent.AutoSize = true;
            lblDisplayStudent.Location = new Point(10, 29);
            lblDisplayStudent.Name = "lblDisplayStudent";
            lblDisplayStudent.Size = new Size(76, 15);
            lblDisplayStudent.TabIndex = 0;
            lblDisplayStudent.Text = "Student: N/A";
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.Gray;
            btnDisplay.Enabled = false;
            btnDisplay.Location = new Point(180, 402);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(92, 23);
            btnDisplay.TabIndex = 4;
            btnDisplay.Text = "Display Scores";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(740, 584);
            Controls.Add(btnDisplay);
            Controls.Add(groupBox1);
            Controls.Add(gbNavigation);
            Controls.Add(gbCounts);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbCounts.ResumeLayout(false);
            gbCounts.PerformLayout();
            gbNavigation.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblStudent;
        private GroupBox gbCounts;
        private Button btnReset;
        private Button btnSubmit;
        private Label lblCountError;
        private TextBox txtNumAssignments;
        private TextBox txtNumStudents;
        private Label lblNumAssignments;
        private Label lblNumStudents;
        private GroupBox gbNavigation;
        private Button btnIndFirst;
        private Button btnIndLast;
        private Button btnIndNext;
        private Button btnIndPrevious;
        private GroupBox groupBox1;
        private Label lblScoreInput;
        private Label lblAssignmentNumber;
        private Label lblDisplayStudent;
        private Button btnSaveScore;
        private TextBox txtNewScore;
        private TextBox txtSelectAssignment;
        private TextBox txtNewName;
        private Button btnChangeName;
        private Button btnDisplay;
        private Label lblStudentList;
        private Label lblAssignmentList;
        private Label lblScoreList;
        private Label lblInfoStatus;
    }
}
