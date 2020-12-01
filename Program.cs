using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 12346, 10);
            Employee o2 = new Employee("Amol", 12346);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);
            Console.ReadLine();
        }
    }
    class Employee
    {
        public Employee(string name = null, decimal basic = 0, short deptNo = 0)
        {
           
            empNo = ++eNo;
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
        }


        #region Properties
        private string name;
        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                    Console.WriteLine("Invalid name");
            }
            get
            {
                return name;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value >2000 && value <10000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid Basic");
                }
            }
            get
            {
                return basic;
            }
        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid DeptNo");
                }
                else
                {
                    deptNo = value;
                }
            }
            get
            {
                return deptNo;
            }
        }

        private int empNo;

        public int EMPNO
        {
            get
            {
                return empNo;
            }
        }

        private static int eNo;
        public static int ENO
        {
            set
            {
                eNo = 0;
            }
            get
            {
                return eNo;
            }
        }
        #endregion


        public decimal getNetSalary()
        {
            return Basic + 2000 + 1000;
        }

    }

}