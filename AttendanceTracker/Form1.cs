using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Xml.Linq;
namespace AttendanceTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            XMLReadWrite.initializeXMLFile(false);
            RecordAttendance();
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            SystemEvents.SessionEnding += new SessionEndingEventHandler(SystemEvents_SessionEnding);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
            displayResult();
            calculateHours();
            
        }

        private void calculateHours()
        {
            if(string.IsNullOrEmpty(checkOutTextBox.Text))
                return;
            DateTime checkInTime = DateTime.Parse(checkInTextBox.Text);
            DateTime checkOutTime = DateTime.Parse(checkOutTextBox.Text);
            TimeSpan duration = checkOutTime - checkInTime;
            numberOfHours.Text = duration.ToString();
        }

        private void displayResult()
        {
            string checkIn = string.Empty, checkOut = string.Empty;
            XAttribute AttributeObj = getAttribute("check-in");
            if (AttributeObj == null)
            {
                new CheckInOut().EnterCheckInOut();
                AttributeObj = getAttribute("check-in");
            }
            checkIn = AttributeObj.Value;

            AttributeObj = getAttribute("check-out");
            if (AttributeObj != null)
                checkOut = AttributeObj.Value;

            checkInTextBox.Text = checkIn;
            checkOutTextBox.Text = checkOut;



        }

        private XAttribute getAttribute(string attribute)
        {
            XElement todaysNode = CheckInOut.getTodaysNode();
            return todaysNode.Attribute(attribute);
        }

        void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            RecordAttendance();
        }

        void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            RecordAttendance();
        }


        private void CheckInOut_Click(object sender, EventArgs e)
        {
            RecordAttendance();
        }
        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs args)
        {
            RecordAttendance();
        }

        private static void RecordAttendance()
        {
            new CheckInOut().EnterCheckInOut();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.ShowBalloonTip(5000);
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecordAttendance();
            displayResult();
            calculateHours();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePicker1.Value;
                getResult(selectedDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getResult(DateTime selectedDate)
        {
            throw new NotImplementedException();
        }
    }

}
