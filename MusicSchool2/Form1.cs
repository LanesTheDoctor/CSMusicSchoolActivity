using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static MusicSchool2.Form1;

namespace MusicSchool2
{
    public partial class Form1 : Form
    {
        private List<Enrolment> enrolmentList;
        private int currentRecord;

        public Form1()
        {
            InitializeComponent();

            enrolmentList = new List<Enrolment>();
            ReadEnrolmentData();
            DisplayEnrolmentData();
            enrolmentList.Sort();
            DisplayEnrolmentData();
            currentRecord = 0;
            DisplayCurrentRecord();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optionally handle UI label clicks
        }

        private void addNew_Button_Click(object sender, EventArgs e)
        {
            if (IsEnrolmentValid() == false)
            {
                return;
            }

            else
            {
                // prompt the user to proceed with the save
                DialogResult dialogResult = MessageBox.Show("Do you wish to proceed in adding this new enrolment record ? ", "NEW ENROLMENT RECORD", MessageBoxButtons.YesNo);

                // if Yes button clicked, then proceed
                if (dialogResult == DialogResult.Yes)
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        // proceed
                        // get all 9 values for the new enrolment
                        string fName = fName_TextBox.Text;
                        string lName = lName_TextBox.Text;
                        string dob = DOB_TextBox.Text;
                        string phone = phone_TextBox.Text;
                        string email = email_TextBox.Text;
                        string instrument = instrument_ComboBox.SelectedItem.ToString();
                        string course = course_ComboBox.SelectedItem.ToString();
                        string startDate = startDate_TextBox.Text;
                        string endDate = endDate_TextBox.Text;

                        // create new enrolment object
                        Enrolment newEnrolment = new Enrolment(fName, lName, dob, phone, email, instrument, course, startDate, endDate);

                        // add to the enrolmentList
                        enrolmentList.Add(newEnrolment);

                        // re-sort the enrolmentList
                        enrolmentList.Sort();

                        // display newly sorted enrolment list
                        DisplayEnrolmentData();

                        // get index number of new enrolment
                        currentRecord = enrolmentList.IndexOf(newEnrolment);
                    }
                }
            }
        }

        public void DisplayEnrolmentData()
        {
            string displayText = "FName\tLName\tInstrum\tCourse\tStartDate\tEndDate\n";
            displayText += "----------------------------------------------------------------------\r\n";

            foreach (var enrolment in enrolmentList)
            {
                displayText += enrolment.ToString() + "\r\n";
            }

            enrolments_TextBox.Text = displayText;
        }

        public void DisplayCurrentRecord()
        {
            var current = enrolmentList[currentRecord];
            fName_TextBox.Text = current.FName;
            lName_TextBox.Text = current.LName;
            DOB_TextBox.Text = current.DOB;
            phone_TextBox.Text = current.Phone;
            email_TextBox.Text = current.Email;
            instrument_ComboBox.SelectedItem = current.Instrument;
            course_ComboBox.SelectedItem = current.Course;
            startDate_TextBox.Text = current.StartDate;
            endDate_TextBox.Text = current.EndDate;
        }

        public void ReadEnrolmentData()
        {
            string filePath = @"enrolments.csv";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader file = new StreamReader(filePath))
                    {
                        string line;
                        int lineCount = 0;

                        while ((line = file.ReadLine()) != null)
                        {
                            lineCount++;
                            if (lineCount == 1) continue;

                            string[] lineArray = line.Split(',');

                            string fName = lineArray[0];
                            string lName = lineArray[1];
                            string dob = lineArray[2];
                            string phone = lineArray[3];
                            string email = lineArray[4];
                            string instrument = lineArray[5];
                            string course = lineArray[6];
                            string startDate = lineArray[7];
                            string endDate = lineArray[8];

                            Enrolment enrolment = new Enrolment(fName, lName, dob, phone, email, instrument, course, startDate, endDate);
                            enrolmentList.Add(enrolment);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: File not found - " + filePath);
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show("ERROR reading file:\n" + ioe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Unexpected error:\n" + e.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            fName_TextBox.Text = "";
            lName_TextBox.Text = "";
            DOB_TextBox.Text = "";
            phone_TextBox.Text = "";
            email_TextBox.Text = "";
            startDate_TextBox.Text = "";
            endDate_TextBox.Text = "";
        }

        public bool IsEnrolmentValid()
        {
            bool enrolmentStatus = true;
            string errorMessage = "ERROR(S) encountered\n";
            // 1. check first name
            if (string.IsNullOrEmpty(fName_TextBox.Text))
            {
                errorMessage += "First name is required\n";
                enrolmentStatus = false;
            }

            // 2. check last name
            if (string.IsNullOrEmpty(lName_TextBox.Text))
            {
                errorMessage += "Last name is required\n";
                enrolmentStatus = false;
            }

            // 3. check date of birth
            if (string.IsNullOrEmpty(DOB_TextBox.Text))
            {
                if (string.IsNullOrEmpty(DOB_TextBox.Text))
                {
                    errorMessage += "Date of Birth is required (format: dd / mm / yyyy\n";
                    enrolmentStatus = false;
                }

                else if (IsDateFormatValid(DOB_TextBox.Text) == false)
                {
                    errorMessage += "Date of Birth must be in the correct format: dd / mm / yyyy)\n";
                    enrolmentStatus = false;
                }
            }

            // 4. check phone
            if (string.IsNullOrEmpty(phone_TextBox.Text))
            {
                errorMessage += "Phone is required\n";
                enrolmentStatus = false;
            }

            // 5. check email
            if (string.IsNullOrEmpty(email_TextBox.Text))
            {
                errorMessage += "Email is required\n";
                enrolmentStatus = false;
            }

            // 6. check instrument
            if (instrument_ComboBox.SelectedIndex == -1)
            {
                errorMessage += "Instrument selection is required\n";
                enrolmentStatus = false;
            }

            // 7. check course
            if (course_ComboBox.SelectedIndex == -1)
            {
                errorMessage += "Course selection is required\n";
                enrolmentStatus = false;
            }

            // 8. check start date
            if (string.IsNullOrEmpty(startDate_TextBox.Text))
            {
                errorMessage += "Course start date is required (format: dd / mm / yyyy)\n";
                enrolmentStatus = false;
            }

            // 9. check end date
            if (string.IsNullOrEmpty(endDate_TextBox.Text))
            {
                errorMessage += "Course end date is required (format: dd / mm / yyyy)\n";
                enrolmentStatus = false;
            }

            // display error message if errors encountered
            if (enrolmentStatus == false)
            {
                MessageBox.Show(errorMessage, "ERRORS!");
            }
            return enrolmentStatus;
        }

        public bool IsDateFormatValid(string dateString)
        {
            // boolean variable which is returned from this method
            bool isDateFormatValid = true;

            // string dateStr must contain 10 characters e.g. "06/03/2001"
            if (dateString.Length == 10)
            {
                // convert dateString to a character array
                char[] charArray = dateString.ToCharArray();

                // loop through each character in the array
                for (int i = 0; i < charArray.Length; i++)
                {
                    // check [2] and [5] - these characters must be '/'
                    if (i == 2 || i == 5)
                    {
                        if (!charArray[i].Equals('/'))
                        {
                            isDateFormatValid = false;
                            break;
                        }
                    }
                    else if (!char.IsDigit(dateString[i]))
                    {
                        isDateFormatValid = false;
                        break;
                    }
                } // end for loop
            }

            else
            {
                isDateFormatValid = false;
            }

            return isDateFormatValid;
        } // end of IsDateFormatValid() method

        private void update_Button_Click(object sender, EventArgs e)
        {
            if (IsEnrolmentValid() == false)
            {
                return;
            }

            else
            {
                string originalFName = enrolmentList[currentRecord].FName;

                // prompt the user to proceed with the save
                DialogResult dialogResult = MessageBox.Show("Do you wish to proceed in updating the record for " + originalFName + " ? ", "UPDATE EXISTING ENROLMENT RECORD", MessageBoxButtons.YesNo);

                // if Yes button clicked, then proceed
                if (dialogResult == DialogResult.Yes)
                {
                    // proceed
                    // get all 9 values for the new enrolment
                    string fName = fName_TextBox.Text;
                    string lName = lName_TextBox.Text;
                    string dob = DOB_TextBox.Text;
                    string phone = phone_TextBox.Text;
                    string email = email_TextBox.Text;
                    string instrument = instrument_ComboBox.SelectedItem.ToString();
                    string course = course_ComboBox.SelectedItem.ToString();
                    string startDate = startDate_TextBox.Text;
                    string endDate = endDate_TextBox.Text;

                    // create new enrolment object
                    Enrolment updatedEnrolment = new Enrolment(fName, lName, dob, phone, email, instrument, course, startDate, endDate);

                    // change current record enrolmentList
                    enrolmentList[currentRecord] = updatedEnrolment;
                    // re-sort the enrolmentList
                    enrolmentList.Sort();

                    // display newly sorted enrolment list
                    DisplayEnrolmentData();

                    // get index number of new enrolment
                    currentRecord = enrolmentList.IndexOf(updatedEnrolment);
                }
            }
        }

        private void prev_Button_Click(object sender, EventArgs e)
        {
            // go to the previous record in the enrolmentList
            currentRecord--;

            // check if currentRecord not less than zero
            // if so, then assign to last element index
            // (or Count – 1) of the enrolmentList
            // this being the last record
            if (currentRecord < 0)
            {
                currentRecord = enrolmentList.Count - 1;
            }

            // display this record in the enrolments listing
            DisplayCurrentRecord();
        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            // go to the next record in the enrolmentList
            currentRecord++;

            // check if currentRecord not greater than the list length - 1
            // if so, then assign to first element index [0]
            // of the enrolmentList
            // this being the first record
            if (currentRecord == enrolmentList.Count)
            {
                currentRecord = 0;
            }

            // display this record in the enrolments listing
            DisplayCurrentRecord();
        }

        private void find_Button_Click(object sender, EventArgs e)
        {
            // check if the search text box is not empty
            if (string.IsNullOrEmpty(find_TextBox.Text))
            {
                MessageBox.Show("Last name is required in the search field", "ERROR!");
                return;
            }

            else
            {
                // look for the last name in the enrolmentsList
                // string of the search item (last name)
                string recordToSearch = find_TextBox.Text;

                // boolean for foundStatus
                bool foundStatus = false;

                // linear search through the list
                for (int i = 0; i < enrolmentList.Count; i++)
                {
                    // check if last name exists in the list
                    if (recordToSearch.Equals(enrolmentList[i].LName))
                    {
                        // if found, change currentRecord to the index
                        currentRecord = i;

                        // display the found record
                        DisplayCurrentRecord();

                        // inform the user that the record was found
                        MessageBox.Show(recordToSearch + " found!", "FOUND!");

                        // change the foundStatus to true
                        foundStatus = true;

                        // break out of the loop
                        break;
                    }
                } // end for loop

                // check if not found
                if (foundStatus == false)
                {
                    // inform the user that the record was NOT found
                    MessageBox.Show(recordToSearch + " NOT found!", "NOT FOUND");
                }
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are to exit the application - do you wish to SAVE changes to all records ? ", "SAVE!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // save all records from the list
                if (enrolmentList.Count > 0)
                {
                    // save to external file
                    try
                    {
                        string filePath = @"enrolments.csv";

                        // StreamWriter object
                        StreamWriter sw = new StreamWriter(filePath);

                        // Write out headings
                        sw.WriteLine
                        ("FName,LName,DOB,Phone,Email,Instrument,Course,StartDate,EndDate");

                        // loop through each instance
                        // and write a line for each instance
                        for (int i = 0; i < enrolmentList.Count; i++)
                        {
                            sw.WriteLine(enrolmentList[i].ToCSVString());
                        }

                        //Close the file
                        sw.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: Problem in writing to external file!", "ERROR!");
                    }
                }
            }

            // exit the application
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}

