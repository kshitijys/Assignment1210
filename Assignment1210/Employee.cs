using Assignment1210;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1210
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double basicsal, hra, da, pf, netpaid;
        private static int count;

        public Employee(string name, double basicsal)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsal = basicsal;
        }
        public virtual void calculatesal()
        {
            hra = basicsal * 0.40;
            da = basicsal * 0.30;
            pf = basicsal * 0.20;
            netpaid = (basicsal + da + hra) - pf;
        }
        public static string TotalCount()
        {
            return $"total coun ={count}";
        }
        public override string ToString()
        {
            return $"employee details =  id={id} name={name} salry={netpaid}";
        }


    }

    public class Manager : Employee
    {
        private double ta;
        public Manager(string name, double bsal, double ta) : base(name, bsal)
        {
            this.ta = ta;
        }
        public override void calculatesal()
        {
            hra = basicsal * 0.40;
            da = basicsal * 0.30;
            pf = basicsal * 0.20;
            netpaid = (basicsal + da + hra + ta) - pf;
        }
        public override string ToString()
        {
            return $"Manager details -->Id :{id} Name :{name} Salary {netpaid}";
        }

    }

    public class President : Employee
    {
        private double ot;

        public President(string name, double bsal, double ot) : base(name, bsal)
        {
            this.ot = ot;
        }
        public override void calculatesal()
        {
            hra = basicsal * 0.40;
            da = basicsal * 0.30;
            pf = basicsal * 0.20;
            netpaid = (basicsal + da + hra + ot) - pf;
        }
        public override string ToString()
        {
            return $"president Deatails -->Id :{id} Name :{name} Salary {netpaid}";
        }
    }

    public class Salesmanager : Employee
    {
        private double comm;

        public Salesmanager(string name,double bsal,double comm):base(name,bsal)
        {
            this.comm = comm;
        }

        public override void calculatesal()
        {
            hra = basicsal * 0.40;
            da = basicsal * 0.30;
            pf = basicsal * 0.20;
            netpaid = (basicsal + da + hra + comm) - pf;
        }
        public override string ToString()
        {
            return $"sales manager details -->Id :{id} Name :{name} Salary {netpaid}";
        }
    }
}

           

