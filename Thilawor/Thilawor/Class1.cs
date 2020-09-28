using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Thilawor
{
    public class Airline
    {
        public string Destination;
        public string Type_Plane;
        public string flight_number;
        public string minute;
        public string hour;
        public string seconds;
        public string day;
        public string month;
        public string years;
        public string weekDay;
        public int[] Day_month = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        DateTime dt1 = new DateTime();
        //public DateTime dt1_
        //{
        //    get
        //    {
        //        return dt1;
        //    }
        //    set
        //    {
        //        switch ((int)dt1.DayOfWeek()) 
        //        {
        //            case 1:
        //                weekDay = "Monday";
        //            break;
        //            case 2:
        //                weekDay = "tuesday";
        //                break;
        //            case 3:
        //                weekDay = "wednsday";
        //                break;
        //            case 4:
        //                weekDay = "thustday";
        //                break;
        //            case 5:
        //                weekDay = "friday";
        //                break;
        //            case 6: 
        //                break;
        //            case 7:
        //                break; 
        //        }
        //    }
        //}

        ///////////////////////////
        public string Destination_
        {
            get
            {
                return Destination;
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
                else
                    Destination = value;
            }
        }
        ///////////////////////////
        public string Type_Plane_
        {
            get
            {
                return Type_Plane;
            }
            set
            {
                if (value == "" && fail == 0)
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
                else
                    Type_Plane = value;
            }
        }
        ///////////////////////////
        public string flight_number_
        {
            get
            {
                return flight_number;
            }
            set
            {
                if (int.Parse(value) >= Int32.MaxValue)
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
                else
                    flight_number = value;
            }
        }
        ///////////////////////////
        public string minute_
        {
            get
            {
                return minute;
            }
            set
            {
                if (60 > Convert.ToInt32(value) && fail == 0)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        } 
        ///////////////////////////
        public string hour_
        {
            get
            {
                return hour;
            }
            set
            {
                if (24 > Convert.ToInt32(value))
                {
                    hour = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        public string day_
        {
            get
            {
                return day;
            }
            set
            {
                int month = int.Parse(this.month);
                if (int.Parse(value) < 32 && Day_month[month-1]>int.Parse(value))
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        ///////////////////////////
        public string month_
        {
            get
            {
                return month;
            }
            set
            {
                if (int.Parse(value) < 13)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
        ///////////////////////////
        public string years_
        {
            get
            {
                return years;
            }
            set
            {
                int year = Convert.ToInt32(time_Now.ToString("yyyy"));
                if (year > Convert.ToInt32(value))
                {
                    years = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        } 
        // not fact
        ///////////////////////////
        public string[] weekDays = new string[] { "Mon", "Tues", "Wed", "Thut", "Frid", "Sat", "Sund" };
        ///////////////////////////
        public string weekDay_
        {
            get
            {
                return weekDay;
            }
            set
            {
                for (int i = 0; i < 7; i++)
                {
                    if (value != weekDays[i] && fail == 0)
                    {
                        Console.WriteLine("Error cant be written");
                        fail++;
                    }
                    else
                    {
                        weekDay = value;
                        break;
                    }
                }
            }
        }
        ///////////////////////////
        public int fail = 0;
        public DateTime time_Now = DateTime.Now;
        ///////////////////////////
        public string seconds_
        {
            get
            {
                return seconds;
            }
            set
            {
                if (int.Parse(value) < 61)
                {
                    seconds = value;
                }
                else
                {
                    Console.WriteLine("Error cant be written");
                    fail++;
                }
            }
        }
    }
    ///////////////////////////
    class Class1
    {
        static void day(string string_1, Airline[] array_airline, int j)
        {
            for(int i = 0; i < j; i++)
            {
                if (array_airline[i].weekDay == string_1)
                {
                    Console.WriteLine("Destination:" + array_airline[i].Destination);
                    Console.WriteLine("Type plane: " + array_airline[i].Type_Plane);
                    Console.WriteLine("flight number" + array_airline[i].flight_number);
                    Console.WriteLine("Week day" + array_airline[i].weekDay);
                    Console.WriteLine("Plane arrive:" + array_airline[i].years + "." + array_airline[i].month + "." + array_airline[i].day + " time: " + array_airline[i].hour + ":" + array_airline[i].minute + ":" + array_airline[i].seconds);
                    Console.WriteLine();
                }
            }
        }
        static void day_week(string string_, Airline[] array_airline, int j)
        {
            for (int i = 0; i < j; i++)
            {
                if (array_airline[i].Destination == string_)
                {
                    Console.WriteLine("Destination:" + array_airline[i].Destination);
                    Console.WriteLine("Type plane: " + array_airline[i].Type_Plane);
                    Console.WriteLine("flight number" + array_airline[i].flight_number);
                    Console.WriteLine("Week day" + array_airline[i].weekDay);
                    Console.WriteLine("data time: " + array_airline[i].time_Now);
                    Console.WriteLine("Plane arrive:" + array_airline[i].years + "." + array_airline[i].month + "." + array_airline[i].day + " time: " + array_airline[i].hour + ":" + array_airline[i].minute + ":" + array_airline[i].seconds);
                    Console.WriteLine();
                }
            }
        }
        static void Cout(Airline[] array_airline, int j)
        {
            for(int i=0; i < j; i++)
            {
                if (array_airline[i].fail == 0)
                {
                    Console.WriteLine("Destination:" + array_airline[i].Destination);
                    Console.WriteLine("Type plane: " + array_airline[i].Type_Plane);
                    Console.WriteLine("flight number" + array_airline[i].flight_number);
                    Console.WriteLine("Week day" + array_airline[i].weekDay);
                    Console.WriteLine("data time now: " + array_airline[i].time_Now);
                    Console.WriteLine("Plane arrive:" + array_airline[i].years + "." + array_airline[i].month + "." + array_airline[i].day + " time: " + array_airline[i].hour + ":" + array_airline[i].minute + ":" + array_airline[i].seconds);
                    Console.WriteLine();
                }
            }
        }
        static void add(Airline[] array_airline,int i,int j)
        {
            if (j == i - 1)
            {
                Array.Resize(ref array_airline, i + 1);
                i++;
            }
            Console.Write("Enter destination: ");
            array_airline[j].Destination_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            Console.Write("Enter flight number: ");
            array_airline[j].flight_number_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            Console.Write("Enter type plane: ");
            array_airline[j].Type_Plane_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            Console.Write("Enter minute arrive: ");
            array_airline[j].minute_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            Console.Write("Enter hour arrive: ");
            array_airline[j].hour_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            Console.Write("Enter month arrive: ");
            array_airline[j].month_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            Console.Write("Enter day arrive: ");
            array_airline[j].day_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            
            Console.Write("Enter years arrive: ");
            array_airline[j].years_ = Console.ReadLine();

            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                return;
            }
            Console.Write("Enter week day: ");
            array_airline[j].weekDay_ = Console.ReadLine();
            if (array_airline[j].fail > 0)
            {
                Console.WriteLine("Error written");
                array_airline[j].fail = 0;
            }
            else
            {
                array_airline[j].fail = 0;
                j += 1;
            }
        }
        //////////////////////////////////////////
        static void Main(string[] args)
        {
            int i = 2, error = 0, j = 0;//ошибки и добавление к массиву индекс перемещения
            Airline[] array_airline = new Airline[2];
            for (int k = 0; k < 2; k++)
                array_airline[k] = new Airline();

            for (; ; )
            {
                Console.WriteLine("Make a choice:");
                Console.WriteLine("1 - Add new:");
                Console.WriteLine("2 - Display a list of flights for a given destination:");
                Console.WriteLine("3 - Display a list of flights for a given day of the week:");
                Console.WriteLine("4 - Display content: ");
                Console.WriteLine("5 - Exit:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                     
                    case 1:
                        add(array_airline, i, j);
                        break;
                    case 2: 
                        Console.WriteLine("Enter destinition: ");
                        string string_ = Console.ReadLine();
                        day(string_, array_airline, j);
                        break;
                    case 3:
                        Console.WriteLine("Enter week day: ");
                        string string_1 = Console.ReadLine();
                        day_week(string_1, array_airline, j); 
                        break;
                    case 4:
                        Cout(array_airline, j);
                        break;
                    case 5:

                    default:
                        Console.WriteLine("Input error");
                        break;
                }
            }
        }
    }
}





//////////////////////////////////////////////////////////////////////////////////////////////
/////after for
//array_airline[j].Destination = "minsk";
//array_airline[j].flight_number = "10";
//array_airline[j].Type_Plane = "minsk-2020";
//array_airline[j].minute = "20";
//array_airline[j].hour = "19";
//array_airline[j].day = "12";
//array_airline[j].month = "9";
//array_airline[j].years = "2020";
//array_airline[j].weekDay = "Sun";





//////////////////////////////////////////////////////////////////////////////////////////////
////func
//////////////////////////////////////////////
//static void add1(Airline[] array_airline, int i, int j, string str_1, string str_2, string str_3, string str_4, string str_5, string str_6, string str_7, string str_8, string str_9)
//{
//    Array.Resize(ref array_airline, i + 1);
//    i++; 
//    Console.Write("Enter destination: ");
//    str_1 = Console.ReadLine();
//    Console.Write("Enter flight number: ");
//    str_2 = Console.ReadLine();
//    Console.Write("Enter type plane: ");
//    str_3 = Console.ReadLine();
//    Console.Write("Enter minute arrive: ");
//    str_4 = Console.ReadLine();
//    Console.Write("Enter hour arrive: ");
//    str_5 = Console.ReadLine();
//    Console.Write("Enter day arrive: ");
//    str_6 = Console.ReadLine();
//    Console.Write("Enter month arrive: ");
//    str_7 = Console.ReadLine();
//    Console.Write("Enter years arrive: ");
//    str_8 = Console.ReadLine();
//    Console.Write("Enter week day: ");
//    str_9 = Console.ReadLine();
//    array_airline[j] = new Airline(str_1, str_2, str_3, str_4, str_5, str_6, str_7, str_8, str_9);
//}


////////////////////////////////////////////////////////////////////////////////////////
/////////В Airline Class
///////////////////////////////////////
//static Airline(/*string minute, string hour, string day, string month, string years, int j*/)
//{
//    if (fail == 0)
//    {
//        int yearlng = int.Parse(this.years);
//        int monthlng = int.Parse(this.month);
//        int daylng = int.Parse(this.day);
//        int hourslng = int.Parse(this.hour);
//        int minutelng = int.Parse(this.minute);
//        int secondlng = int.Parse(this.seconds);

//        date1 = new DateTime(yearlng, monthlng, daylng, hourslng, minutelng, secondlng); // год - месяц - день
//    }
//}





///////////////////////////////////////////////////////////////////////////////////////////////
/////////after all
//Console.WriteLine("Do you want add new data in database(y/n)");
//string ch1 = Console.ReadLine();
//i = 1; error = 0;
////Airline[] array_airline = new Airline[1];
//for (; ; )
//{
//    error = 0;
//    Console.WriteLine("Do you want add new data in database(y/n)");
//    ch1 = Console.ReadLine();
//    if (ch1 == "y")
//    {
//        Array.Resize(ref array_airline, i + 1);
//        i += 1;
//        Console.WriteLine("Do you want add new data in database(y/n)");
//        array_airline[i].Destination = Console.ReadLine();
//    }
//    else if (ch1 == "n")
//    {
//        do
//        {
//            //главная прога
//            //
//            Console.WriteLine("Do you want end work(y/n)");
//            ch1 = Console.ReadLine();
//            if (ch1 == "y")
//            {
//                Console.ReadKey();
//            }
//            else if (ch1 == "n")
//            {
//            }
//            else
//            {
//                Console.WriteLine("Error, repeat again");
//                error = 1;
//            }
//        }
//        while (error == 1);
//    }
//    else
//    {
//        Console.WriteLine("Error, repeat again");
//    }
//}