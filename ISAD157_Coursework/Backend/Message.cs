using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD157_Coursework.Backend
{
    class Message
    {
        #region attributes
        int recieverID;
        string dateTime;
        string msg;
        #endregion attributes

        #region constructors
        public Message(int inRecieverID, DateTime inDateTime, string inMsg)
        {
            recieverID = inRecieverID;
            dateTime = Convert.ToString(inDateTime);
            msg = inMsg;
        }
        #endregion constructors

        #region methods

        #region getters
        public int getRecieverID()
        {
            return recieverID;
        }

        public string getDateTime()
        {
            return dateTime;
        }

        public string getMsg()
        {
            return msg;
        }
        #endregion getters

        //setters aren't needed for this method

        #endregion methods
    }
}
