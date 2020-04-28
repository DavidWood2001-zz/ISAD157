using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD157_Coursework.Backend
{
    class Friend
    {
        #region attributes
        int userID;
        string fName;
        string lName;
        #endregion attributes

        #region constructors
        public Friend(int inUserID, string inFName, string inLName)
        {

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
        #endregion setters

        #endregion methods
    }
}
