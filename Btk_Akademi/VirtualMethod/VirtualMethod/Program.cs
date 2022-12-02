using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            
            OracleServer oracleServer= new OracleServer();
            oracleServer.Add();

            Console.ReadLine();



        }
    }

    class DataBase 
    {
        public virtual void Add() 
        {
            Console.WriteLine("Varsayılan Eklendi");
        }
        public virtual void Remove() 
        {
            Console.WriteLine("Varsayılan Silindi");
        }
    }

    class SqlServer: DataBase
    {
        public override void Add()
        {
            Console.WriteLine("QQ");
            //base.Add();
        }
    }
    
    class OracleServer: DataBase 
    {
        
    }
}
