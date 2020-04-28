using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD157_Coursework.Backend
{
    class Workplace
    {
        #region attributes
        string name;
        string strtTime;
        string endTime;
        #endregion attributes

        #region constructors
        //Creates workplace object if user no longer works there (end time is present)
        public Workplace(string inName, DateTime inStrtTime, DateTime inEndTime)
        {
            name = setName(inName);
            strtTime = setStrtTime(inStrtTime);
            endTime = setEndTime(inEndTime);
        }
        //Creates workplace object if user is still an employee (no end time)
        public Workplace(string inName, DateTime inStrtTime)
        {
            name = setName(inName);
            strtTime = setStrtTime(inStrtTime);
            endTime = "Current";
        }
        #endregion constructors

        #region methods

        #region getters
        public string getName()
        {
            return name;
        }
        public string getStrtTime()
        {
            return strtTime;
        }

        public string getEndTime()
        {
            return endTime;
        }
        #endregion getters

        #region setters
        //Setters have been added for the future
        //The client may request the ability to edit workplaces so this has been added here
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
