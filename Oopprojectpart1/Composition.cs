using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopprojectpart1
{
    internal class Composition
    {
        public int USERIDD;
        public int BALANCEE;

        public Composition(int u, int b)
        {
            USERIDD = u;
            BALANCEE = b;
        }

        public void displaybal()
        {
            Console.WriteLine("User ID: {0}", USERIDD);
            Console.WriteLine("Balance: {0}", BALANCEE);
        }
    }

    class Booking1
    {
        Composition C = new Composition(1, 250);
        public string passengername;
        public int seats;
        public int seatcost=25;

        public Booking1(string p, int s)
        {
            passengername = p;
            seats = s;
        }

        public void updateaccout()
        {
            int totalbillll = seats * seatcost;
            C.BALANCEE = C.BALANCEE - totalbillll;
        }

        public void deisplaydetails()
        {
            Console.WriteLine("Passenger Name: {0}", passengername);
            Console.WriteLine("Seats: {0}", seats);
            Console.WriteLine("User ID: {0}", C.USERIDD);
            Console.WriteLine("Balance: {0}", C.BALANCEE);
        }
    }

    class program1
    {
        public void main()
        {
            Booking1 b11 = new Booking1("Hasnain",2);
            b11.deisplaydetails();
        }
    }
}
