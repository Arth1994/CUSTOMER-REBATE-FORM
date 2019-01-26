using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//This class represents the application logic of the system hence it is named model
namespace Asg2_axs175430
{
    class Entry : IEquatable<Entry>
    {
        //field declarations which encompass our application logic
        public string firstName;
        public string middleInitial;
        public string lastName;
        public string addressLine1;
        public string addressLine2;
        public string city;
        public string state;
        public string zipCode;
        public string gender;
        public string phoneNumber;
        public string emailAddress;
        public string proofOfPurchase;
        public DateTime dateRecieved; 
        public TimeSpan startTime, endTime;
        public string numberOfKeyPresses;

        //Empty constructor initialization
        public Entry()
        {

        }
        //Overloaded Parameterized Constructor 
        public Entry(string fName, string mInital, string lName, string addrLine1, string addrLine2, string formCity, string formState, string code, string formGender, string number, string emailId, string proof, DateTime receivedDate, TimeSpan start, TimeSpan end, string kepPresses)
        {
            firstName = fName;
            middleInitial = mInital;
            lastName = lName;
            addressLine1 = addrLine1;
            addressLine2 = addrLine2;
            city = formCity;
            state = formState;
            zipCode = code;
            gender = formGender;
            phoneNumber = number;
            emailAddress = emailId;
            proofOfPurchase = proof;
            dateRecieved = receivedDate;
            startTime = start;
            endTime = end;
            numberOfKeyPresses = kepPresses;
        }

        //Interface being implemented to specify equality instances
        public bool Equals(Entry other)
        {
            if ((firstName == other.firstName) && (middleInitial == other.middleInitial)
                && (lastName == other.lastName) && (addressLine1 == other.addressLine1)
                && (addressLine2 == other.addressLine2) && (city == other.city)
                && (state == other.state) && (zipCode == other.zipCode) && (gender == other.gender)
                && (phoneNumber == other.phoneNumber) && (emailAddress == other.emailAddress)
                && (startTime == other.startTime) && (endTime == other.endTime) && (numberOfKeyPresses == other.numberOfKeyPresses))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        internal bool blankEntryValidatorNames(string f1, string f2, string f3)
        {
            //throw new NotImplementedException();
            firstName = f1;
            lastName = f3;
            if (firstName == " " || lastName == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool namesAreNotValid(string f1, string f2, string f3)
        {
            //Regular Expression if the first name, middle initial or the last name doesn't contain any special characters or numbers
            //throw new NotImplementedException();
            String first = f1;
            String middle = f2;
            String last = f3;
            String regex = @"^([0-9]|#|\+|\*)+$";

            Regex input = new Regex(regex, RegexOptions.IgnoreCase);
            Match m1 = input.Match(first);
            Match m2 = input.Match(middle);
            Match m3 = input.Match(last);


            if (m1.Success || m2.Success || m3.Success)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean addEntry(List<Entry> entries)
        {
            DataLayer d = new DataLayer();
            if (d.writeRecords(entries))
            {
                return true;
            }
            return false;
        }

        //Checking if the same 
        public Boolean isUniqueValues(string f1, string mi, string lname, List<Entry> entries)
        {
            foreach (Entry e in entries)
            {

                if (e.firstName.Equals(f1, StringComparison.OrdinalIgnoreCase) && e.middleInitial.Equals(mi, StringComparison.OrdinalIgnoreCase)
                    && e.lastName.Equals(lname, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

            }
            return true;
        }

        internal bool checkAddrLine2(string addressLine2)
        {
            //throw new NotImplementedException();
            return true;

        }

        //check Address Line1 is empty or not
        internal bool checkAddrLine1(string addressLine1)
        {
            //throw new NotImplementedException();
            if (addressLine1 == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //checks if city, state and zipcode are not null
        internal bool checkGivenLocationIsValid(string city, string state, string zipcode)
        {
            //throw new NotImplementedException();
            this.city = city;
            this.state = state;
            this.zipCode = zipcode;
            if ((this.city == "") || (this.state == "") || (this.zipCode == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check if gender is not a value
        internal bool checkGenderIsNull(string gender)
        {
            //throw new NotImplementedException();
            this.gender = gender;
            if (this.gender == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check if number entered is not a bad value
        internal bool checkIfNumberIsValid(string no)
        {
            //throw new NotImplementedException();
            phoneNumber = no;
            if (phoneNumber == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal bool notNullProof(string proof)
        {
            //throw new NotImplementedException();
            proofOfPurchase = proof;
            if (proofOfPurchase == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //For Email Null as well Invalid Operations
        internal bool emailNotNull(string email)
        {
            emailAddress = email;
            String expression = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex r = new Regex(expression, RegexOptions.IgnoreCase);
            Match m = r.Match(email);


            if (emailAddress == "" || (!m.Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }


}
