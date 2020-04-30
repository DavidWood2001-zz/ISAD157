using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD157_Coursework.Backend
{
    public class Friend
    {
        #region attributes
        int userID;
        string fName;
        string lName;
        #endregion attributes

        #region constructors
        public Friend(int inUserID)
        {
            userID = setUserID(inUserID);
        }
        #endregion constructors

        #region methods

        #region getters
        public int getUserID()
        {
            return userID;
        }

        public string getFName()
        {
            return fName;
        }

        public string getLName()
        {
            return lName;
        }
        #endregion getters

        #region setters
        public int setUserID(int inUserID)
        {
            //check if user exists
            bool userExists = ISAD157_Library.SQL_Connection_Functions.userExists(inUserID);
            //if user exists change the ID
            if (userExists)
            {
                userID = inUserID;
                //Change the name (call setFName and setLName)
                fName = setFName(inUserID);
                lName = setLName(inUserID);
            }
            else
            {
                //if they don't display an error message
                MessageBox.Show("Sorry but that user doesn't exist.");
            }
            return userID;
        }

        private string setFName(int inUserID)
        {
            //get name from db
            //change name in form
            fName = ISAD157_Library.SQL_Connection_Functions.returnFName(inUserID); ;
            return fName;
        }
        private string setLName(int inUserID)
        {
            //get name from db
            //change name in form
            lName = ISAD157_Library.SQL_Connection_Functions.returnLName(inUserID);
            return lName;
        }
        #endregion setters

        #endregion methods
    }
}
