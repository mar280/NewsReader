using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace NewsReader
{
    public class News
    {
        public int id_sort;
        private String _id;
        private String _name;
        private String _cat;
        private String _date;
        private String _detail;

        public DateTime realDate;
        public String day;
        private String[] days = { "«·”» ", "«·√Õœ", "«·√À‰Ì‰", "«·À·«À«¡", "«·√—»⁄«¡", "«·Œ„Ì”", "«·Ã„⁄…"};
        public News()
        {
        }
        public String Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                id_sort = int.Parse(_id);
            }
        }
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public String Cat
        {
            get
            {
                return _cat;
            }
            set
            {
                _cat = value;
            }
        }
        public String Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                try
                {
                    _date.Trim();
                    string temp =_date.Split(' ')[0].Trim();
                    realDate = DateTime.ParseExact(temp, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
                    day = getDay();

                }
                catch(Exception ee){ }
            }
        }

        private string getDay()
        {
            if (realDate.DayOfWeek ==  DayOfWeek.Saturday)
            {
                return days[0];
            }
            else if (realDate.DayOfWeek ==  DayOfWeek.Sunday)
            {
                return days[1];
            }
            else if (realDate.DayOfWeek == DayOfWeek.Monday)
            {
                return days[2];
            }
            else if (realDate.DayOfWeek == DayOfWeek.Tuesday)
            {
                return days[3];
            }
            else if (realDate.DayOfWeek == DayOfWeek.Wednesday)
            {
                return days[4];
            }
            else if (realDate.DayOfWeek == DayOfWeek.Thursday)
            {
                return days[5];
            }
            else if (realDate.DayOfWeek == DayOfWeek.Friday)
            {
                return days[6];
            }
            return "";
        }
        public String Detail
        {
            get
            {
                return _detail;
            }
            set
            {
                _detail = value;
            }
        }

    }
}
