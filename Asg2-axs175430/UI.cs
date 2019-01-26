using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Asg2_axs175430
{
    public partial class RebateForm : Form
    {
        //dataLayer object for reading, creating and writing to files
        DataLayer d = new DataLayer();

        //BackSpace Tracker
        public int backSpaceTracker;

        //list to store different entries
        List<Entry> entries = new List<Entry>();

        //custom column sorter class for sorting listveiw columns
        private CustomComparator lvSorter;

        //start time instantiation
        public TimeSpan start;
        //public TimeSpan unsetDate = null;

        //end time instantiation
        public TimeSpan end;

        //flags for add, modify and delete
        int flag, index;


        //Record Start Time 
        private void textFName_KeyUp(object sender, EventArgs e)
        {

        }

        public RebateForm()
        {
            //if new file is created then initial form object
            if (d.CreateDatatFile())
            {
                InitializeComponent();
                Controls.Add(listView1);
                lvSorter = new CustomComparator();
                //assign listview sorter to 
                listView1.ListViewItemSorter = lvSorter;
            }


        }
        //Check Validations For Name
        public Boolean validateNames(TextBox textBox1, TextBox textMiddle, TextBox textBox3)
        {
            Entry entry = new Entry();
            string f1 = textBox1.Text;
            string f2 = textMiddle.Text;
            string f3 = textBox3.Text;

            try
            {
                if (entry.blankEntryValidatorNames(f1, f2, f3))
                {
                    textBox2.BackColor = Color.DeepPink;
                    textBox2.Text = "Please Fill Out both the First Name and Last Name";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            //return true;
        }



        //After form load function goes into add mode
        private void RebateForm_Load(object sender, EventArgs e)
        {

            expandScreen();
            toolStripStatusLabel1.Text = "ADD MODE";
            flag = 1;

            foreach (Entry entry in d.readRecords())
            {
                //Loading the form and display the results
                entries.Add(entry);
                string fullName = entry.firstName + " " + entry.middleInitial + " " + entry.lastName;
                string[] header = { fullName, entry.phoneNumber };
                var listViewItem = new ListViewItem(header);
                listView1.Items.Add(listViewItem);
                listView1.Refresh();
            }

        }



        //Add Functionality
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //end time before clicking add button  
            end = DateTime.Now.TimeOfDay;
            //int keyPresses = backSpaceTracker;
            //Applying various checks before add to the file
            //Creating default entry constructor
            Entry entry = new Entry();
            int value = backSpaceTracker;
            if (validateNames(textFName, textBoxMI, textBoxLN) && validatePhoneNumber(textBoxPhone.Text) && validateEmail(textBoxEmail.Text) && validateGender(comboBoxGender.Text) && validateAddressLine1(textAddress1.Text) && isValidProof(comboBoxProof.Text))
            {
                if (entry.isUniqueValues(textFName.Text, textBoxMI.Text, textBoxLN.Text, entries))
                {
                    //Instantiatiing parametertized constructor
                    Entry entry1 = new Entry(textFName.Text, textBoxMI.Text, textBoxLN.Text,
                        textAddress1.Text, textBoxAddress2.Text, textBoxCity.Text, textBoxState.Text, textBoxZipCode.Text,
                        comboBoxGender.Text, textBoxPhone.Text, textBoxEmail.Text, comboBoxProof.Text,
                        dateTimePicker1.Value, start, end, backSpaceTracker.ToString());

                    ListViewItem item = new ListViewItem();
                    string fullName = entry1.firstName + " " + entry1.middleInitial + " " + entry1.lastName;

                    //puting into header
                    string[] header = { fullName, entry1.phoneNumber };

                    var listViewItem = new ListViewItem(header);
                    listView1.Items.Add(listViewItem);
                    //Storing an entry
                    entries.Add(entry1);
                    entry1.addEntry(entries);
                    //Entered Successfully
                    textBox2.BackColor = Color.DarkGreen;
                    String starthour = entry1.startTime.Hours.ToString();
                    String startminute = entry1.startTime.Minutes.ToString();
                    String startsecond = entry1.startTime.Seconds.ToString();

                    String endhour = entry1.endTime.Hours.ToString();
                    String endminute = entry1.endTime.Minutes.ToString();
                    String endsecond = entry1.endTime.Seconds.ToString();
                    textBox2.Text = "Successfully added, " + "Start Time: " +
                        starthour + ":" + startminute + ":" + startsecond +
                        " End Time: " + endhour + ":" + endminute + ":" + endsecond;
                    //Clear All textBoxes after adding
                    clearAllFields();
                    //get cursor to the top 
                    getCursorToTop();
                    flag = 1;
                    toolStripStatusLabel1.Text = "ADD MODE";
                }
                else
                {
                    //When there is a duplicate entry
                    textBox2.BackColor = Color.DeepPink;
                    textBox2.Text = "Duplicate Entry";
                }
            }
            else
            {
                //Invalid Input
                textBox2.BackColor = Color.DeepPink;
                textBox2.Text = "Please Enter All Required Fields!";
            }
        }

        //validating address line2
        private bool validateAddressLine2(string text)
        {
            //throw new NotImplementedException();
            Entry entry = new Entry();
            string address = text;
            if (entry.checkAddrLine2(address))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //validating address line1
        private bool validateAddressLine1(string text)
        {
            //throw new NotImplementedException();
            Entry entry = new Entry();
            string address = text;
            if (entry.checkAddrLine1(address))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isValidProof(string text)
        {
            //throw new NotImplementedException();
            Entry entry = new Entry();
            string proof = text;
            if (entry.notNullProof(proof))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool validateEmail(string text)
        {
            //throw new NotImplementedException();
            string email = text;
            Entry entry = new Entry();
            if (entry.emailNotNull(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validatePhoneNumber(string number)
        {
            Entry entry = new Entry();
            string no = number;
            if (entry.checkIfNumberIsValid(no))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validateGender(string text)
        {
            //throw new NotImplementedException();
            Entry entry = new Entry();
            string gender = text;
            if (entry.checkGenderIsNull(gender))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //TO check validity of Location
        private bool validateLocation(string text1, string text2, string text3)
        {
            Entry entry = new Entry();

            string city = text1;
            string state = text2;
            string zipcode = text3;

            if (entry.checkGivenLocationIsValid(city, state, zipcode))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void storeAllValues()
        {
            Entry entry = entries[index];
            listView1.Refresh();
            textFName.Text = entry.firstName;
            textBoxMI.Text = entry.middleInitial;
            textBoxLN.Text = entry.lastName;
            textAddress1.Text = entry.addressLine1;
            textBoxAddress2.Text = entry.addressLine2;
            textBoxCity.Text = entry.city;
            textBoxState.Text = entry.state;
            textBoxZipCode.Text = entry.zipCode;
            comboBoxGender.Text = entry.gender;
            textBoxPhone.Text = entry.phoneNumber;
            textBoxEmail.Text = entry.emailAddress;
            comboBoxProof.Text = entry.proofOfPurchase;
            dateTimePicker1.Value = entry.dateRecieved;
            listView1.Refresh();
        }

        private void getCursorToTop()
        {
            textFName.Select();
        }

        //Modify an entry
        private void btnModify_Click(object sender, EventArgs e)
        {
            //end time before clicking add button  
            end = DateTime.Now.TimeOfDay;
            //Applying various checks before modifying to the file
            //Creating default entry constructor
            Entry entry = new Entry();
            if (listView1.SelectedItems.Count > 0)
            {
                if (validateNames(textFName, textBoxMI, textBoxLN) && validatePhoneNumber(textBoxPhone.Text) && validateEmail(textBoxEmail.Text) && validateGender(comboBoxGender.Text) && validateAddressLine1(textAddress1.Text) && isValidProof(comboBoxProof.Text))
                {
                    if (entry.isUniqueValues(textFName.Text, textBoxMI.Text, textBoxLN.Text, entries))
                    {
                        //Instantiatiing parametertized constructor
                        Entry entry1 = new Entry(textFName.Text, textBoxMI.Text, textBoxLN.Text,
                            textAddress1.Text, textBoxAddress2.Text, textBoxCity.Text, textBoxState.Text, textBoxZipCode.Text,
                            comboBoxGender.Text, textBoxPhone.Text, textBoxEmail.Text, comboBoxProof.Text,
                            dateTimePicker1.Value, start, end, backSpaceTracker.ToString());

                        ListViewItem item = new ListViewItem();
                        string fullName = entry1.firstName + " " + entry1.middleInitial + " " + entry1.lastName;

                        //putting into header
                        string[] header = { fullName, entry1.phoneNumber };
                        listView1.Refresh();
                        var listViewItem = new ListViewItem(header);
                        listView1.Refresh();
                        listView1.Items.RemoveAt(index);
                        listView1.Refresh();
                        entries.RemoveAt(index);
                        //Storing an entry
                        entries.Add(entry1);
                        listView1.Refresh();
                        entry1.addEntry(entries);
                        listView1.Refresh();
                        textBox2.Text = "Successfully added Modified";
                        //Clear All textBoxes after adding
                        clearAllFields();
                        //get cursor to the top 
                        getCursorToTop();
                        flag = 1;
                        toolStripStatusLabel1.Text = "ADD MODE";
                    }
                    else
                    {
                        //When there is a duplicate entry
                        textBox2.BackColor = Color.DeepPink;
                        textBox2.Text = "Duplicate Entry";
                    }
                }
                else
                {
                    //Invalid Fields
                    textBox2.BackColor = Color.DeepPink;
                    textBox2.Text = "Please Check if fields are entered";
                }
            }
            else
            {
                textBox2.BackColor = Color.DeepPink;
                textBox2.Text = "Please Select an Item";
            }
        }

        //Delete Selected
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(index);
                listView1.Refresh();
                entries.RemoveAt(index);
                entry.addEntry(entries);
                clearAllFields();
                getCursorToTop();
                textBox2.Text = "Record Deleted!";
                textBox2.BackColor = Color.DarkGreen;
                flag = 1;
                toolStripStatusLabel1.Text = "ADD MODE";
            }
            else
            {
                //deletion failed
                textBox2.BackColor = Color.DeepPink;
                textBox2.Text = "Cannot Delete";
            }
        }

        //clear all content in the textboxes once ADD and MODIFY is implemented
        private void clearAllFields()
        {
            //Reseting All TextBoxes 
            textFName.Text = "";
            textBoxMI.Text = "";
            textBoxLN.Text = "";
            textAddress1.Text = "";
            textBoxAddress2.Text = "";
            textBoxCity.Text = "";
            textBoxState.Text = "";
            textBoxZipCode.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            //Resetting Combo Boxes
            comboBoxGender.Text = "";
            comboBoxProof.Text = "";
            //Resetting Date Picker
            dateTimePicker1.ResetText();
            //Resetting Response Messages
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            listView1.Refresh();

        }

        //Adjusting the Working Screen Size according to the resolution programmatically
        private void expandScreen()
        {
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - Height;
            Height += iHeight;
            Point pt = listView1.Location;
            pt.Y += Height;
            Point pt1 = textBox2.Location;
            pt1.Y += iHeight;
            //Point col1 = 
            //listView1.Location = pt;
            //textBox2.Location = pt1;
            int iWidth = Screen.PrimaryScreen.WorkingArea.Width - Width;
            //textBox2.Width += iWidth;
            //listView1.Width += iWidth;
            //this.Width += iWidth;
            CenterToScreen();

        }

        private void textFName__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }


        private void textFName_TextChanged(object sender, EventArgs e)
        {
            //error checking on firstname
            //todo: this start should be set to null when entry is saved 
            start = DateTime.Now.TimeOfDay;
            rulesForNname(textFName);
        }


        private void textFName_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            rulesForNname(textFName);
        }

        private void rulesForNname(TextBox textFName)
        {
            String regex = @"^([0-9]|#|\+|\*)+$";
            Regex input = new Regex(regex, RegexOptions.IgnoreCase);
            Match m1 = input.Match(textFName.Text);
            if (m1.Success)
            {
                textFName.BackColor = Color.DeepPink;
                textBox2.Text = "No numbers or special characters in name please";
            }
        }

        private void textBoxMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }


        private void textBoxMI_TextChanged(object sender, EventArgs e)
        {
            //error checking on middle initial
            rulesForMI(textBoxMI);
        }

        private void textBoxMI_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            rulesForMI(textBoxMI);
        }


        private void rulesForMI(TextBox textBoxMI)
        {
            //throw new NotImplementedException();
            String regex = @"^([0-9]|#|\+|\*)+$";
            Regex input = new Regex(regex, RegexOptions.IgnoreCase);
            Match m1 = input.Match(textBoxMI.Text);
            if (m1.Success)
            {
                textBoxMI.BackColor = Color.DeepPink;
                textBox2.Text = "No numbers or special characters in name please";
            }

        }

        //last name keypress to count number of backspaces
        private void textBoxLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void textBoxLN_TextChanged(object sender, EventArgs e)
        {
            //error checking on last name
            rulesForLN(textBoxLN);
        }

        private void textBoxLN_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            rulesForLN(textBoxLN);
        }


        private void rulesForLN(TextBox textBoxLN)
        {
            //throw new NotImplementedException();
            String regex = @"^([0-9]|#|\+|\*)+$";
            Regex input = new Regex(regex, RegexOptions.IgnoreCase);
            Match m1 = input.Match(textBoxLN.Text);
            if (m1.Success)
            {
                textBoxLN.BackColor = Color.DeepPink;
                textBox2.Text = "No numbers or special characters in name please";
            }
        }

        //when text changes in last name text box
        private void textBoxLN_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        //Address Line 1 keypress to count number of backspaces
        private void textAddress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void textAddress1_TextChanged(object sender, EventArgs e)
        {
            //error checking on Address Line1
            rulesForAddr1(textAddress1);
        }

        private void rulesForAddr1(TextBox textAddress1)
        {
            //throw new NotImplementedException();
        }

        private void textBoxAddress1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void textBoxAddress2_TextChanged(object sender, EventArgs e)
        {
            //error checking on Address Line2
        }


        private void textBoxAddress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            //error checking for city
            rulesForCity(textBoxCity);
        }


        private void textBoxCity_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            rulesForCity(textBoxCity);
        }


        private void rulesForCity(TextBox textBoxCity)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            String regex = @"^([0-9]|#|\+|\*)+$";
            Regex input = new Regex(regex, RegexOptions.IgnoreCase);
            Match m1 = input.Match(textBoxCity.Text);
            if (m1.Success)
            {
                textBoxCity.BackColor = Color.DeepPink;
                textBox2.Text = "No numbers or special characters in City please";
            }

        }

        private void textBoxCity__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void textBoxState_TextChanged(object sender, EventArgs e)
        {
            //error checking on State
            rulesOfState(textBoxState);
        }

        private void textBoxState_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            rulesOfState(textBoxState);
        }

        private void rulesOfState(TextBox textBoxState)
        {
            //throw new NotImplementedException();
            String regex = @"^([0-9]|#|\+|\*)+$";
            Regex input = new Regex(regex, RegexOptions.IgnoreCase);
            Match m1 = input.Match(textBoxState.Text);
            if (m1.Success)
            {
                textBoxState.BackColor = Color.DeepPink;
                textBox2.Text = "No numbers or special characters in State Name please";
            }


        }

        private void textBoxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            //error checking on ZipCode
            rulesOfCode(textBoxZipCode);
        }


        private void textBoxZipCode_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            rulesOfCode(textBoxZipCode);
        }

        private void rulesOfCode(TextBox textBoxZipCode)
        {
            //throw new NotImplementedException();
            if (!(Regex.IsMatch(textBoxZipCode.Text, @"^\d+$")))
            {
                textBoxZipCode.BackColor = Color.DeepPink;
                textBox2.Text = "InValid ZipCode";
            }
        }

        //KeyPress 
        private void textBoxZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            //error checking on Number
            rulesOfNumber(textBoxPhone);
        }

        private void textBoxPhone_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            rulesOfNumber(textBoxPhone);
        }


        private void rulesOfNumber(TextBox textBoxPhone)
        {
            if (!(Regex.IsMatch(textBoxPhone.Text, @"^\d+$")))
            {
                textBoxPhone.BackColor = Color.DeepPink;
                textBox2.Text = "InValid PhoneNumber";
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            //error checking on Email
            //rulesOfEmail(textBoxEmail);
        }

        private void textBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs eventArgs)
        {
            //swtich back to original
            //rulesOfEmail(textBoxEmail);
        }

        //combo box gender user controls
        private void comboBoxGender_KeyDown(object sender, KeyEventArgs e)
        {
            comboBoxGender.DroppedDown = false;
        }

        //combo box purchase user controls
        private void comboBoxProof_KeyDown(object sender, KeyEventArgs e)
        {
            comboBoxProof.DroppedDown = false;
        }


        private void textBoxemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                backSpaceTracker++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            if (listView1.SelectedItems.Count > 0)
            {
                index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                flag = 2;
                toolStripStatusLabel1.Text = "Currently Modifying ot Deleting the Entries";
                storeAllValues();

            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            // Determine if  column is sorted.
            if (e.Column == lvSorter.SortColumn)
            {
                // Reverse the sort direction
                if (lvSorter.Order == SortOrder.Ascending)
                {
                    lvSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                //default to ascending.
                lvSorter.SortColumn = e.Column;
                lvSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort 
            listView1.Sort();
        }

        private void comboBoxProof_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        //when we modify or delete a listview entry
        private void listView1_MouseCLick(object sender, MouseEventArgs e)
        {
            Entry entry = new Entry();
            if (listView1.SelectedItems.Count > 0)
            {
                index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                flag = 2;
                toolStripStatusLabel1.Text = "Currently Modifying ot Deleting the Entries";
                storeAllValues();

            }
        }


    }
}
