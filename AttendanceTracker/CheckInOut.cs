using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Globalization;
using System.Configuration;


namespace AttendanceTracker
{
    class CheckInOut
    {
        private static string _filePath = ConfigurationManager.AppSettings["filepath"];//"F:\\VS\\AttendanceTracker\\XML\\" + DateTime.Now.Year.ToString() + ".xml";
        private DateTime _now;
        public CheckInOut(DateTime curDateTime)
        {
            _now = curDateTime;
        }
        public CheckInOut()
        {
            _now = DateTime.Now;
        }
        public static XElement getTodaysNode()
        {
            XDocument doc = XDocument.Load(_filePath);
            CheckInOut obj = new CheckInOut();
            IEnumerable<XElement> days = obj.getDaysOfAMonth(doc);
            XElement currentDayNode = obj.getTodaysNode(days);
            return currentDayNode;
        }
        public void EnterCheckInOut(bool isCheckOut = false)
        {
            XDocument doc = XDocument.Load(_filePath);
            IEnumerable<XElement> days = getDaysOfAMonth(doc);
            XElement currenDayNode = getTodaysNode(days);
            XAttribute checkIn = currenDayNode.Attribute("check-in");
            if (checkIn == null)
            {
                currenDayNode.SetAttributeValue("check-in", XMLReadWrite.getOnlyTime(_now));

            }
            else
            {
                currenDayNode.SetAttributeValue("check-out", XMLReadWrite.getOnlyTime(_now));
            }
            doc.Save(_filePath);
        }

        private XElement getTodaysNode(IEnumerable<XElement> days)
        {
            string today = XMLReadWrite.getOnlyDate(_now);
            foreach (XElement day in days)
            {
                string thisDate = day.Attribute("date").Value;
                if (string.Equals(thisDate, today, StringComparison.InvariantCulture))
                {

                    return day;
                }
            }
            return null;
        }

        private IEnumerable<XElement> getDaysOfAMonth(XDocument doc)
        {

            string monthName = XMLReadWrite.getMonthName(_now.Month);
            XElement root = doc.Element("Attendance");
            IEnumerable<XElement> days = root.Descendants(monthName).Elements();
            return days;
        }



    }

    class XMLReadWrite
    {
        private static string _filePath = ConfigurationManager.AppSettings["filepath"];//"F:\\VS\\AttendanceTracker\\XML\\" + DateTime.Now.Year.ToString() + ".xml";
        private static int _year = DateTime.Now.Year;

        public static string getOnlyDate(DateTime date)
        {
            return date.Date.ToShortDateString();
        }
        public static string getOnlyTime(DateTime date)
        {
            return date.ToShortTimeString();
        }

        public static string getMonthName(int month)
        {
            CultureInfo IN = CultureInfo.InvariantCulture;
            DateTimeFormatInfo format = IN.DateTimeFormat;
            return format.MonthNames[month - 1];
        }
        public static void initializeXMLFile(bool excludeWeekends = true, int year = 0, bool cleanUpExistingFile = false)
        {
            if (year == 0)
                year = _year;
            if (File.Exists(_filePath) == true)
            {
                if (!cleanUpExistingFile)
                    return;
                else
                {
                    File.Delete(_filePath);
                }
            }
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.NewLineOnAttributes = true;
            xmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;
            using (XmlWriter writer = XmlWriter.Create(_filePath, xmlWriterSettings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Attendance");
                writer.WriteAttributeString("year", _year.ToString());
                for (int i = 0; i < 12; i++)
                {
                    string monthName = getMonthName(i + 1);
                    writer.WriteStartElement(monthName);

                    for (int j = 0; j < DateTime.DaysInMonth(_year, i + 1); j++)
                    {
                        int day = j + 1;
                        int month = i + 1;
                        DateTime date = new DateTime(year, month, day);
                        DayOfWeek dayOfWeek = date.DayOfWeek;
                        if (excludeWeekends)
                            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
                                continue;
                        writer.WriteStartElement("Day");
                        writer.WriteAttributeString("date", getOnlyDate(date));
                        writer.WriteAttributeString("day", date.DayOfWeek.ToString());
                        writer.WriteEndElement();

                    }

                    writer.WriteEndElement();

                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
        }

    }
}
