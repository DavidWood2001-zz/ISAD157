using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD157_Coursework.Backend
{
    class User
    {
        #region attributes
        int userID;
        string fName;
        string lName;
        string hometown;
        string gender;
        string relStatus;
        string townOrCity;
        Workplace[] lstWorkplaces;
        School[] lstSchools;
        Message[] lstSentMessages;
        Message[] lstRecMessages;
        Friend[] lstFriends;
        #endregion attributes

        #region constructors
        #endregion constructors

        #region methods

        #region getters
        public int getUserID()
        {
            return userID;
        }
        public string getfName()
        {
            return fName;
        }
        public string getLName()
        {
            return lName;
        }
        public string getHometown()
        {
            return hometown;
        }
        public string getGender()
        {
            return gender;
        }
        public string getRelStatus()
        {
            return relStatus;
        }
        public string getTownOrCity()
        {
            return townOrCity;
        }
        public Workplace[] getWorkplaces()
        {
            return lstWorkplaces;
        }
        public School[] getSchools()
        {
            return lstSchools;
        }
        public Message[] getSentMessages()
        {
            return lstSentMessages;
        }
        public Message[] getRecMessages()
        {
            return lstRecMessages;
        }
        public Friend[] getFriends()
        {
            return lstFriends;
        }
        #endregion getters

        #region setters
        public int setUserID(int inUserID)
        {
            //check if user exists
            //if user exists change the ID
            //Change the name (call setFName and setLName)
            //if they don't display an error message
            MessageBox.Show("Sorry but that user doesn't exist.");
            return 0;
        }
        public string setFName()
        {
            //get name from db
            //change name in form
            return "None";
        }
        public string setLName()
        {
            //get name from db
            //change name in form
            return "None";
        }
        public string setHometown()
        {
            //get hometown from db
            //change hometown in form
            return "None";
        }
        public string setGender()
        {
            //get gender from db
            //change gender in form
            return "None";
        }
        public string setRelStatus()
        {
            //get relStatus from db
            //change relStatus in form
            return "None";
        }
        public string setTownOrCity()
        {
            //get town/city from db
            //change town/city in form
            return "None";
        }
        public Workplace[] setWorkplaces()
        {
            //get workplaces from db
            //change workplaces in form
            return null;
        }
        public School[] setSchools()
        {
            //get schools from db
            //change school in form
            return null;
        }
        public Message[] setSentMessages()
        {
            //get messages sent from db
            //change the messages sent in form
            return null;
        }
        public Message[] setRecMessages()
        {
            //get messages recieved from db
            //change the messages recieved in form
            return null;
        }
        public Friend[] setFriends()
        {
            //get friend from db
            //get friends names from db
            //change friends in form
            return null;
        }
        #endregion setters

        #endregion methods
    }
}
