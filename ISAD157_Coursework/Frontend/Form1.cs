using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISAD157_Coursework.Backend;
using ISAD157_Library;

namespace ISAD157_Coursework
{
    public partial class Form1 : Form
    {
        public static User[] lstUsers = new User[0];
        Workplace[] lstCurWorkplaces = new Workplace[0];
        School[] lstCurSchools = new School[0];
        Friend[] lstCurFriends = new Friend[0];
        Backend.Message[] lstCurSentMsgs = new Backend.Message[0];
        Backend.Message[] lstCurRecMsgs = new Backend.Message[0];
        int selectedUser;
        //added colours for future to be able to add them to the design as borders
        string usrColour = "#F5793A";
        string sentMsgColour = "#A95AA1";
        string recMsgColour = "#85C0F9";
        string msgTextColour = "#0F2080";
        public Form1()
        {
            InitializeComponent();
            try
            {
                Array.Resize(ref lstUsers, 0);
                SQL_Connection_Functions.retrieveUsers();
                DataTable dt = new DataTable();
                SQL_Connection_Functions.sqlDA.Fill(dt);
                createUsers(dt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not connect due to the following error. " + err.Message);
            }
        }

        #region createObjects
        public void createUsers(DataTable dt)
        {
            int curUser = 0;
            Array.Resize(ref lstUsers, 0);
            foreach (DataRow row in dt.Rows)
            {
                Array.Resize(ref lstUsers, lstUsers.Length + 1);
                int userID = row.Field<int>(0);
                string fName = row.Field<string>(1);
                string lName = row.Field<string>(2);
                string hometown = row.Field<string>(3);
                string gender = row.Field<string>(4);
                string relStatus = row.Field<string>(5);
                string townOrCity = row.Field<string>(6);
                Workplace[] lstWorkplaces = null;
                School[] lstSchools = null;
                Backend.Message[] lstSentMessages = null;
                Backend.Message[] lstRecMessages = null;
                Friend[] lstFriends = null;
                lstUsers[curUser] = new User(userID, fName, lName, hometown, gender, relStatus, townOrCity, lstWorkplaces, lstSchools
                    , lstSentMessages, lstRecMessages, lstFriends);
                curUser++;
            }
            for (int i = 0; i < lstUsers.Length; i++)
            {
                lstBoxUsers.Items.Add(lstUsers[i].getfName() + " " + lstUsers[i].getLName());
            }
        }
        public void retrieveWorkplaces(int inUserID)
        {
            Array.Resize(ref lstCurWorkplaces, 0);
            //replace 1 with the variable for the currently selected user
            SQL_Connection_Functions.retrieveWorkplaces(inUserID);
            DataTable dt = new DataTable();
            SQL_Connection_Functions.sqlDA.Fill(dt);
            int curWorkplace = 0;
            foreach (DataRow row in dt.Rows)
            {
                Array.Resize(ref lstCurWorkplaces, lstCurWorkplaces.Length + 1);
                int userID = row.Field<int>(0);
                string placename = row.Field<string>(1);
                string startTime = row.Field<string>(2);
                string endTime = row.Field<string>(3);
                lstCurWorkplaces[curWorkplace] = new Workplace(userID, placename, startTime, endTime);
                curWorkplace++;
            }
            for (int i = 0; i < lstCurWorkplaces.Length; i++)
            {
                lstBoxWorkplaces.Items.Add(lstCurWorkplaces[i].getName());
            }
        }
        public void retrieveSchools(int inUserID)
        {
            Array.Resize(ref lstCurSchools, 0);
            //replace 1 with the variable for the currently selected user
            SQL_Connection_Functions.retrieveSchools(inUserID);
            DataTable dt = new DataTable();
            SQL_Connection_Functions.sqlDA.Fill(dt);
            int curSchool = 0;
            foreach (DataRow row in dt.Rows)
            {
                Array.Resize(ref lstCurSchools, lstCurSchools.Length + 1);
                int userID = row.Field<int>(0);
                string placename = row.Field<string>(1);
                string startTime = row.Field<string>(2);
                string endTime = row.Field<string>(3);
                lstCurSchools[curSchool] = new School(userID, placename, startTime, endTime);
                curSchool++;
            }
            for (int i = 0; i < lstCurSchools.Length; i++)
            {
                lstBoxSchools.Items.Add(lstCurSchools[i].getName());
            }
        }
        public void retrieveFriends(int inUserID)
        {
            //If users friends not added create the list
            if (lstUsers[inUserID].getFriends() == null) {
                Array.Resize(ref lstCurFriends, 0);
                //replace 1 with the variable for the currently selected user
                SQL_Connection_Functions.retrieveFriends(inUserID);
                DataTable dt = new DataTable();
                SQL_Connection_Functions.sqlDA.Fill(dt);
                int curFriend = 0;
                foreach (DataRow row in dt.Rows)
                {
                    Array.Resize(ref lstCurFriends, lstCurFriends.Length + 1);
                    int friendID = row.Field<int>(1);
                    lstCurFriends[curFriend] = new Friend(friendID);
                    curFriend++;
                }
                lstUsers[inUserID].setFriends(lstCurFriends);
            }
            //Otherwise retrieve the list
            else
            {
                lstCurFriends = lstUsers[inUserID].getFriends();
            }
            //Show the list
            for (int i = 0; i < lstCurFriends.Length; i++)
            {
                string friendsName = lstCurFriends[i].getFName() + " " + lstCurFriends[i].getLName();
                Console.WriteLine(friendsName);
                lstBoxFriends.Items.Add(friendsName);
            }
        }
        public void retrieveSentMessages(int inUserID)
        {
            if (lstUsers[inUserID].getSentMessages() == null)
            {
                Array.Resize(ref lstCurSentMsgs, 0);
                //replace 1 with the variable for the currently selected user
                SQL_Connection_Functions.retrieveSentMsgs(inUserID);
                DataTable dt = new DataTable();
                SQL_Connection_Functions.sqlDA.Fill(dt);
                int curSentMsg = 0;
                foreach (DataRow row in dt.Rows)
                {
                    Array.Resize(ref lstCurSentMsgs, lstCurSentMsgs.Length + 1);
                    int senderID = row.Field<int>(0);
                    int recID = row.Field<int>(1);
                    string dateTime = row.Field<string>(2); ;
                    string msg = row.Field<string>(3); ;
                    lstCurSentMsgs[curSentMsg] = new Backend.Message(senderID, recID, dateTime, msg);
                    curSentMsg++;
                }
                lstUsers[inUserID].setSentMessages(lstCurSentMsgs);
            }
            else
            {
                lstCurSentMsgs = lstUsers[inUserID].getSentMessages();
            }
            for (int i = 0; i < lstCurSentMsgs.Length; i++)
            {
                int recID = lstCurSentMsgs[i].getRecieverID();
                string recFName = SQL_Connection_Functions.returnFName(recID);
                string recLName = SQL_Connection_Functions.returnLName(recID); ;
                lstBoxTo.Items.Add(recFName + " " + recLName);
            }
        }
        public void retrieveRecMessages(int inUserID)
        {
            if (lstUsers[inUserID].getRecMessages() == null)
            {
                Array.Resize(ref lstCurRecMsgs, 0);
                //replace 1 with the variable for the currently selected user
                SQL_Connection_Functions.retrieveRecMsgs(inUserID);
                DataTable dt = new DataTable();
                SQL_Connection_Functions.sqlDA.Fill(dt);
                int curRecMsg = 0;
                foreach (DataRow row in dt.Rows)
                {
                    Array.Resize(ref lstCurRecMsgs, lstCurRecMsgs.Length + 1);
                    int senderID = row.Field<int>(0);
                    int recID = row.Field<int>(1);
                    string dateTime = row.Field<string>(2); ;
                    string msg = row.Field<string>(3); ;
                    lstCurRecMsgs[curRecMsg] = new Backend.Message(senderID, recID, dateTime, msg);
                    curRecMsg++;
                }
                lstUsers[inUserID].setRecMessages(lstCurRecMsgs);
            }
            else
            {
                lstCurRecMsgs = lstUsers[inUserID].getRecMessages();
            }
            for (int i = 0; i < lstCurRecMsgs.Length; i++)
            {
                int senderID = lstCurRecMsgs[i].getSenderID();
                string recFName = lstUsers[senderID - 1].getfName();
                string recLName = lstUsers[senderID - 1].getLName();
                lstBoxFrom.Items.Add(recFName + " " + recLName);
            }
        }
        #endregion createObjects

        #region userInteractions
        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            showUserInfo();
            showUserWorkplaces();
            showUserSchools();
            showUserFriends();
            showSentMsgs();
            showRecMsgs();
        }
        private void lstBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMsgContent(lstCurSentMsgs[lstBoxTo.SelectedIndex]);
        }
        private void lstBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMsgContent(lstCurSentMsgs[lstBoxFrom.SelectedIndex]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchUser(txtSearchUser.Text);
        }
        #endregion userInteractions

        #region displayInformation

        private void showUserInfo()
        {
            selectedUser = lstBoxUsers.SelectedIndex;
            User userObject = lstUsers[selectedUser];
            txtUserID.Text = Convert.ToString(userObject.getUserID());
            txtUserName.Text = userObject.getfName() + " " + userObject.getLName();
            txtHometown.Text = userObject.getHometown();
            txtGender.Text = userObject.getGender();
            txtRelStatus.Text = userObject.getRelStatus();
            txtTownOrCity.Text = userObject.getTownOrCity();
        }
        private void showUserWorkplaces()
        {
            lstBoxWorkplaces.Items.Clear();
            retrieveWorkplaces(selectedUser);
        }
        private void showUserSchools()
        {
            lstBoxSchools.Items.Clear();
            retrieveSchools(selectedUser);
        }
        private void showUserFriends()
        {
            lstBoxFriends.Items.Clear();
            retrieveFriends(selectedUser);
        }
        private void showSentMsgs()
        {
            lstBoxTo.Items.Clear();
            retrieveSentMessages(selectedUser);
        }
        private void showRecMsgs()
        {
            lstBoxFrom.Items.Clear();
            retrieveRecMessages(selectedUser);
        }
        private void showMsgContent(Backend.Message inMsg)
        {
            txtMsgText.Text = inMsg.getMsg();
        }
        #endregion displayInformation

        #region searchUser
        public void searchUser(string inSearch)
        {
            selectedUser = -1;
            lstBoxUsers.Items.Clear();
            try
            {
                int userID = Convert.ToInt32(inSearch);
                Array.Resize(ref lstUsers, 0);
                SQL_Connection_Functions.searchUsers(userID);
                DataTable dt = new DataTable();
                SQL_Connection_Functions.sqlDA.Fill(dt);
                createUsers(dt);
            }
            catch
            {
                Array.Resize(ref lstUsers, 0);
                SQL_Connection_Functions.searchUserFName(inSearch);
                DataTable dt = new DataTable();
                SQL_Connection_Functions.sqlDA.Fill(dt);
                createUsers(dt);
            }
            finally
            {
                if (inSearch == "")
                {
                    Array.Resize(ref lstUsers, 0);
                    SQL_Connection_Functions.retrieveUsers();
                    DataTable dt = new DataTable();
                    SQL_Connection_Functions.sqlDA.Fill(dt);
                    createUsers(dt);
                }
            }
        }
        #endregion searchUser

    }
}
