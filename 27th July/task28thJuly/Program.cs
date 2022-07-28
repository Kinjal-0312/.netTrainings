using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task28thJuly
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterName ename = new EnterName();
            ename.banned += WarningAlarm;
            ename.User();
            Console.Read();
        }
        static void WarningAlarm(object sender, BannedUserEventArgs e)
        {
            Console.WriteLine("{0} Users Found. Sending Email to Administration.", e.Name);
            Console.WriteLine("Email Sent to the administrator.");
            Console.WriteLine("Warning!!");
            //for the sound
            for(; ; )
            {
                Console.Beep();
            }
        }
    }

    public class EnterName
    {
        public event EventHandler<BannedUserEventArgs> banned;
        public void User()
        {
            Console.Write("Enter You Name : ");
            string user = Console.ReadLine();

            if ((user == "Ram" || user == "Sham" || user == "Naveen") && (banned != null))
            {
                banned(this, new BannedUserEventArgs(user));
            }
            else
            {
                Console.WriteLine("Welcome to  " + user);
            }
        }
    }

    public class BannedUserEventArgs : EventArgs
    {
        public BannedUserEventArgs(string a)
        {
            Name = a;
        }
        public string Name { get; set; }
    }
}
