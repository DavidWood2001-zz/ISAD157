using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD157_Coursework.Backend
{
    class School
    {
        #region attributes
        int userID;
        string name;
        string strtTime;
        string endTime;
        #endregion attributes

        #region constructors
        //Creates a school object if user is no longer attending (end time is present)
        public School(int inUserID, string inName, DateTime inStrtTime, DateTime inEndTime)
        {
            userID = setUserID(inUserID);
            name = setName(inName);
            strtTime = setStrtTime(inStrtTime);
            endTime = setEndTime(inEndTime);
        }

        //Creates a school object if user is currently attending (no end time)
        public School(int inUserID, string inName, DateTime inStrtTime)
        {
            userID = setUserID(inUserID);
            name = setName(inName);
            strtTime = setStrtTime(inStrtTime);
            endTime = "Current";
        }
        #endregion constructors

        #region methods

        #region getters

        public int getUserID()
        {
            return userID;
        }
        public string getName()
        {
            return name;
        }

        public string getStrtTime()
        {
            return strtTime;
        }

        public string getendTime()
        {
            return endTime;
        }
        #endregion getters

        #region setters

        public int setUserID(int inUserID)
        {
            userID = inUserID;
            return userID;
        }
        public string setName(string inName)
        {
            name = Convert.ToString(inName);
            return name;
        }

        public string setStrtTime(DateTime inStrtTime)
        {
            strtTime = Convert.ToString(inStrtTime);
            return strtTime;
        }

        public string setEndTime(DateTime inEndTime)
        {
            endTime = Convert.ToString(inEndTime);
            return endTime;
        }
        #endregion setters

        #endregion methods
    }
}
