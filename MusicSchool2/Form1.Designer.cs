//Leave this file alone
namespace MusicSchool2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            header_Panel = new Panel();
            newEnrolment_Panel = new Panel();
            prev_Button = new Button();
            next_Button = new Button();
            exit_Button = new Button();
            update_Button = new Button();
            addNew_Button = new Button();
            clear_Button = new Button();
            instrument_ComboBox = new ComboBox();
            course_ComboBox = new ComboBox();
            label9 = new Label();
            endDate_TextBox = new TextBox();
            label5 = new Label();
            startDate_TextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            email_TextBox = new TextBox();
            label3 = new Label();
            phone_TextBox = new TextBox();
            label4 = new Label();
            DOB_TextBox = new TextBox();
            label2 = new Label();
            lName_TextBox = new TextBox();
            label1 = new Label();
            fName_TextBox = new TextBox();
            enrolments_Panel = new Panel();
            find_TextBox = new TextBox();
            find_Button = new Button();
            label11 = new Label();
            enrolments_TextBox = new TextBox();
            label10 = new Label();
            newEnrolment_Panel.SuspendLayout();
            enrolments_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // header_Panel
            // 
            header_Panel.BackgroundImage = (Image)resources.GetObject("header_Panel.BackgroundImage");
            header_Panel.Location = new Point(2, 1);
            header_Panel.Name = "header_Panel";
            header_Panel.Size = new Size(580, 110);
            header_Panel.TabIndex = 0;
            // 
            // newEnrolment_Panel
            // 
            newEnrolment_Panel.Controls.Add(prev_Button);
            newEnrolment_Panel.Controls.Add(next_Button);
            newEnrolment_Panel.Controls.Add(exit_Button);
            newEnrolment_Panel.Controls.Add(update_Button);
            newEnrolment_Panel.Controls.Add(addNew_Button);
            newEnrolment_Panel.Controls.Add(clear_Button);
            newEnrolment_Panel.Controls.Add(instrument_ComboBox);
            newEnrolment_Panel.Controls.Add(course_ComboBox);
            newEnrolment_Panel.Controls.Add(label9);
            newEnrolment_Panel.Controls.Add(endDate_TextBox);
            newEnrolment_Panel.Controls.Add(label5);
            newEnrolment_Panel.Controls.Add(startDate_TextBox);
            newEnrolment_Panel.Controls.Add(label6);
            newEnrolment_Panel.Controls.Add(label7);
            newEnrolment_Panel.Controls.Add(label8);
            newEnrolment_Panel.Controls.Add(email_TextBox);
            newEnrolment_Panel.Controls.Add(label3);
            newEnrolment_Panel.Controls.Add(phone_TextBox);
            newEnrolment_Panel.Controls.Add(label4);
            newEnrolment_Panel.Controls.Add(DOB_TextBox);
            newEnrolment_Panel.Controls.Add(label2);
            newEnrolment_Panel.Controls.Add(lName_TextBox);
            newEnrolment_Panel.Controls.Add(label1);
            newEnrolment_Panel.Controls.Add(fName_TextBox);
            newEnrolment_Panel.Location = new Point(2, 117);
            newEnrolment_Panel.Name = "newEnrolment_Panel";
            newEnrolment_Panel.Size = new Size(580, 400);
            newEnrolment_Panel.TabIndex = 1;
            // 
            // prev_Button
            // 
            prev_Button.Location = new Point(450, 357);
            prev_Button.Name = "prev_Button";
            prev_Button.Size = new Size(46, 23);
            prev_Button.TabIndex = 25;
            prev_Button.Text = "<";
            prev_Button.UseVisualStyleBackColor = true;
            prev_Button.Click += prev_Button_Click;
            // 
            // next_Button
            // 
            next_Button.Location = new Point(518, 357);
            next_Button.Name = "next_Button";
            next_Button.Size = new Size(46, 23);
            next_Button.TabIndex = 24;
            next_Button.Text = ">";
            next_Button.UseVisualStyleBackColor = true;
            next_Button.Click += next_Button_Click;
            // 
            // exit_Button
            // 
            exit_Button.Location = new Point(489, 123);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(75, 23);
            exit_Button.TabIndex = 23;
            exit_Button.Text = "EXIT";
            exit_Button.UseVisualStyleBackColor = true;
            exit_Button.Click += exit_Button_Click;
            // 
            // update_Button
            // 
            update_Button.Location = new Point(489, 94);
            update_Button.Name = "update_Button";
            update_Button.Size = new Size(75, 23);
            update_Button.TabIndex = 22;
            update_Button.Text = "UPDATE";
            update_Button.UseVisualStyleBackColor = true;
            update_Button.Click += update_Button_Click;
            // 
            // addNew_Button
            // 
            addNew_Button.Location = new Point(489, 65);
            addNew_Button.Name = "addNew_Button";
            addNew_Button.Size = new Size(75, 23);
            addNew_Button.TabIndex = 21;
            addNew_Button.Text = "ADD NEW";
            addNew_Button.UseVisualStyleBackColor = true;
            addNew_Button.Click += addNew_Button_Click;
            // 
            // clear_Button
            // 
            clear_Button.Location = new Point(489, 36);
            clear_Button.Name = "clear_Button";
            clear_Button.Size = new Size(75, 23);
            clear_Button.TabIndex = 20;
            clear_Button.Text = "CLEAR";
            clear_Button.UseVisualStyleBackColor = true;
            clear_Button.Click += clear_Button_Click;
            // 
            // instrument_ComboBox
            // 
            instrument_ComboBox.FormattingEnabled = true;
            instrument_ComboBox.Items.AddRange(new object[] { "Flute", "Guitar", "Piano", "Violin", "Vocals" });
            instrument_ComboBox.Location = new Point(110, 176);
            instrument_ComboBox.Name = "instrument_ComboBox";
            instrument_ComboBox.Size = new Size(350, 23);
            instrument_ComboBox.TabIndex = 19;
            // 
            // course_ComboBox
            // 
            course_ComboBox.FormattingEnabled = true;
            course_ComboBox.Items.AddRange(new object[] { "Level 1", "Level 2", "Level 3" });
            course_ComboBox.Location = new Point(110, 204);
            course_ComboBox.Name = "course_ComboBox";
            course_ComboBox.Size = new Size(350, 23);
            course_ComboBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 260);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 17;
            label9.Text = "End Date:";
            // 
            // endDate_TextBox
            // 
            endDate_TextBox.Location = new Point(110, 260);
            endDate_TextBox.Name = "endDate_TextBox";
            endDate_TextBox.Size = new Size(350, 23);
            endDate_TextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 232);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 15;
            label5.Text = "Start Date:";
            // 
            // startDate_TextBox
            // 
            startDate_TextBox.Location = new Point(110, 232);
            startDate_TextBox.Name = "startDate_TextBox";
            startDate_TextBox.Size = new Size(350, 23);
            startDate_TextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 204);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 13;
            label6.Text = "Course:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 176);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 11;
            label7.Text = "Instrument:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 148);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 9;
            label8.Text = "Email Contact:";
            // 
            // email_TextBox
            // 
            email_TextBox.Location = new Point(110, 148);
            email_TextBox.Name = "email_TextBox";
            email_TextBox.Size = new Size(350, 23);
            email_TextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 120);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Phone Contact:";
            // 
            // phone_TextBox
            // 
            phone_TextBox.Location = new Point(110, 120);
            phone_TextBox.Name = "phone_TextBox";
            phone_TextBox.Size = new Size(350, 23);
            phone_TextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 92);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 5;
            label4.Text = "Date of Birth:";
            // 
            // DOB_TextBox
            // 
            DOB_TextBox.Location = new Point(110, 92);
            DOB_TextBox.Name = "DOB_TextBox";
            DOB_TextBox.Size = new Size(350, 23);
            DOB_TextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 64);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name:";
            // 
            // lName_TextBox
            // 
            lName_TextBox.Location = new Point(110, 64);
            lName_TextBox.Name = "lName_TextBox";
            lName_TextBox.Size = new Size(350, 23);
            lName_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // fName_TextBox
            // 
            fName_TextBox.Location = new Point(110, 36);
            fName_TextBox.Name = "fName_TextBox";
            fName_TextBox.Size = new Size(350, 23);
            fName_TextBox.TabIndex = 0;
            // 
            // enrolments_Panel
            // 
            enrolments_Panel.Controls.Add(find_TextBox);
            enrolments_Panel.Controls.Add(find_Button);
            enrolments_Panel.Controls.Add(label11);
            enrolments_Panel.Controls.Add(enrolments_TextBox);
            enrolments_Panel.Controls.Add(label10);
            enrolments_Panel.Location = new Point(2, 523);
            enrolments_Panel.Name = "enrolments_Panel";
            enrolments_Panel.Size = new Size(580, 236);
            enrolments_Panel.TabIndex = 2;
            // 
            // find_TextBox
            // 
            find_TextBox.Location = new Point(381, 21);
            find_TextBox.Name = "find_TextBox";
            find_TextBox.Size = new Size(100, 23);
            find_TextBox.TabIndex = 4;
            // 
            // find_Button
            // 
            find_Button.Location = new Point(489, 21);
            find_Button.Name = "find_Button";
            find_Button.Size = new Size(75, 23);
            find_Button.TabIndex = 3;
            find_Button.Text = "FIND";
            find_Button.UseVisualStyleBackColor = true;
            find_Button.Click += find_Button_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(307, 21);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 2;
            label11.Text = "Last Name:";
            // 
            // enrolments_TextBox
            // 
            enrolments_TextBox.Location = new Point(16, 53);
            enrolments_TextBox.Multiline = true;
            enrolments_TextBox.Name = "enrolments_TextBox";
            enrolments_TextBox.ScrollBars = ScrollBars.Vertical;
            enrolments_TextBox.Size = new Size(548, 156);
            enrolments_TextBox.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 24);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 0;
            label10.Text = "Enrolments:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 761);
            Controls.Add(enrolments_Panel);
            Controls.Add(newEnrolment_Panel);
            Controls.Add(header_Panel);
            Name = "Form1";
            Text = "Miss Sophie's Music School";
            newEnrolment_Panel.ResumeLayout(false);
            newEnrolment_Panel.PerformLayout();
            enrolments_Panel.ResumeLayout(false);
            enrolments_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header_Panel;
        private Panel newEnrolment_Panel;
        private Panel enrolments_Panel;
        private Label label9;
        private TextBox endDate_TextBox;
        private Label label5;
        private TextBox startDate_TextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox email_TextBox;
        private Label label3;
        private TextBox phone_TextBox;
        private Label label4;
        private TextBox DOB_TextBox;
        private Label label2;
        private TextBox lName_TextBox;
        private Label label1;
        private TextBox fName_TextBox;
        private ComboBox instrument_ComboBox;
        private ComboBox course_ComboBox;
        private Button exit_Button;
        private Button update_Button;
        private Button addNew_Button;
        private Button clear_Button;
        private Button prev_Button;
        private Button next_Button;
        private TextBox enrolments_TextBox;
        private Label label10;
        private TextBox textBox2;
        private Button find_Button;
        private Label label11;
        private TextBox find_TextBox;
    }
}
