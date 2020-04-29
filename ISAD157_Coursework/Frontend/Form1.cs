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
        User[] lstUsers = new User[0];
        Workplace[] lstCurWorkplaces = new Workplace[0];
        School[] lstCurSchools = new School[0];
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
                createUsers();
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not connect due to the following error. " + err.Message);
            }
        }

        public void createUsers()
        {
            ISAD157_functions.retrieveUsers();
            DataTable dt = new DataTable();
            ISAD157_functions.sqlDA.Fill(dt);
            int curUser = 0;
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
            ISAD157_functions.retrieveWorkplaces(inUserID);
            DataTable dt = new DataTable();
            ISAD157_functions.sqlDA.Fill(dt);
            int curWorkplace = 0;
            foreach (DataRow row in dt.Rows)
            {
                Array.Resize(ref lstCurWorkplaces, lstCurWorkplaces.Length + 1);
                int userID = row.Field<int>(0);
                string placename = row.Field<string>(1);
                DateTime startTime = row.Field<DateTime>(2);
                DateTime endTime = row.Field<DateTime>(3);
                lstCurWorkplaces[curWorkplace] = new Workplace(userID, placename, startTime, endTime);
                curWorkplace++;
            }
        }
        public void retrieveSchools(int inUserID)
        {
            Array.Resize(ref lstCurSchools, 0);
            //replace 1 with the variable for the currently selected user
            ISAD157_functions.retrieveSchools(inUserID);
            DataTable dt = new DataTable();
            ISAD157_functions.sqlDA.Fill(dt);
            int curSchool = 0;
            foreach (DataRow row in dt.Rows)
            {
                Array.Resize(ref lstCurSchools, lstCurSchools.Length + 1);
                int userID = row.Field<int>(0);
                string placename = row.Field<string>(1);
                DateTime startTime = row.Field<DateTime>(2);
                DateTime endTime = row.Field<DateTime>(3);
                lstCurSchools[curSchool] = new School(userID, placename, startTime, endTime);
                curSchool++;
            }
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
