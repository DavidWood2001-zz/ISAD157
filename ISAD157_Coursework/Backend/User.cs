using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISAD157_Coursework.Backend
{
    public class User
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
        public User(int inUserID, string inFName, string inLName, string inHometown, string inGender, string inRelStatus, string inTownOrCity,
            Workplace[] inlstWorkplaces, School[] inlstSchools, Message[] inLstSentMessages, Message[] inLstRecMessages, Friend[] inLstFriends)
        {
            userID = setUserID(inUserID);
            fName = setFName(inFName);
            lName = setLName(inLName);
            hometown = setHometown(inHometown);
            gender = setGender(inGender);
            relStatus = setRelStatus(inRelStatus);
            townOrCity = setTownOrCity(inTownOrCity);
            lstWorkplaces = setWorkplaces(inlstWorkplaces);
            lstSchools = setSchools(inlstSchools);
            lstSentMessages = setSentMessages(inLstSentMessages);
            lstRecMessages = setRecMessages(inLstRecMessages);
            lstFriends = setFriends(inLstFriends);
        }
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
            userID = inUserID;
            return userID;
        }
        public int setUserID(int inUserID, bool userEntered)
        {
            //check if user exists
            //if user exists change the ID
            //Change the name (call setFName and setLName)
            setFName();
            setLName();
            //if they don't display an error message
            MessageBox.Show("Sorry but that user doesn't exist.");
            return 0;
        }
        public string setFName(string inFName)
        {
            fName = inFName;
            return fName;
        }
        public string setFName()
        {
            //get name from db
            //change name in form
            return "None";
        }
        public string setLName(string inLName)
        {
            lName = inLName;
            return lName;
        }
        public string setLName()
        {
            //get name from db
            //change name in form
            return "None";
        }
        public string setHometown(string inHomeTown)
        {
            hometown = inHomeTown;
            return hometown;
        }
        public string setGender(string inGender)
        {
            gender = inGender;
            return gender;
        }
        public string setRelStatus(string inRelStatus)
        {
            relStatus = inRelStatus;
            return relStatus;
        }
        public string setTownOrCity(string inTownOrCity)
        {
            townOrCity = inTownOrCity;
            return townOrCity;
        }
        public Workplace[] setWorkplaces(Workplace[] inWorkplaces)
        {
            lstWorkplaces = inWorkplaces;
            return lstWorkplaces;
        }
        public School[] setSchools(School[] inSchools)
        {
            lstSchools = inSchools;
            return lstSchools;
        }
        public Message[] setSentMessages(Message[] inMessages)
        {
            lstSentMessages = inMessages;
            return lstSentMessages;
        }
        public Message[] setRecMessages(Message[] inMessages)
        {
            lstRecMessages = inMessages;
            return lstRecMessages;
        }
        public Friend[] setFriends(Friend[] inFriends)
        {
            lstFriends = inFriends;
            return lstFriends;
        }
        #endregion setters

        #endregion methods
    }
}
