using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            public Manager
        }
    }
    public class Employee
    {
        public Employee(string name = null, int empno = 0, short deptno = 0,abstract decimal basic)
            {
                empno = ++EmpNo;
                Name = name;
                DeptNo = deptno;    
                Basic = basic;
            }
    private string name;
    public string Name
    {
        
        set
        {
            if(value != null)
            {
                {
                    name = value;
                } 
                else
                    Console.WriteLine("");
            }
            get
                {
                return name;
            }
        }
    }

    private int empno;
    public int EmpNo
    {
        get
        {
            return empno;
        }
    }

    private short deptno;
    public short DeptNo
    {
        set
        {
            deptno = 0;
        }
        get
        {
            return deptno;
        }
    }
    public abstract decimal CalcNetSalary();
   
    public class Manager : Employee class
        {
        public Manager(string design)
    {
         public string Designation
    {
        set
        {
            if (value != null)
            {
                design = value;
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }

}

    
       
    }

    public class GeneralManager : Manager
    {
        public string Perks;
    }

    public class CEO : Employee
    {
        public sealed override CalNetSalary();
    }

 }

    

