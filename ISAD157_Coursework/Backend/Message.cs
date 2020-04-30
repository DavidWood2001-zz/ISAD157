using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD157_Coursework.Backend
{
    public class Message
    {
        #region attributes
        int senderID;
        int recieverID;
        string dateTime;
        string msg;
        #endregion attributes

        #region constructors
        public Message(int inSenderID, int inRecieverID, string inDateTime, string inMsg)
        {
            senderID = inSenderID;
            recieverID = inRecieverID;
            dateTime = inDateTime;
            msg = inMsg;
        }
        #endregion constructors

        #region methods

        #region getters
        public int getSenderID()
        {
            return senderID;
        }
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
