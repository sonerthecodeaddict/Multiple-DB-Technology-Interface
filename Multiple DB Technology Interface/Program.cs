using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DalManager manager = new DalManager();
            IPersonDal[] personDals = new IPersonDal[4] { new SqlServerDal(), new MysqlServerDal(), new OraclServereDal(), new OtherServerDal() };

            foreach (var dal in personDals)
            {
                manager.Add(dal);
            }

        }
    }

    interface IPersonDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class OraclServereDal : IPersonDal
    {
        public void Add()
        {
            Console.WriteLine("Add block for oracle server");
        }
        public void Update()
        {
            Console.WriteLine("Update block for oracle server");
        }
        public void Delete()
        {
            Console.WriteLine("Delete block for oracle server");
        }
    }

    class MysqlServerDal : IPersonDal
    {
        public void Add()
        {
            Console.WriteLine("Add block for mysql server");
        }
        public void Update()
        {
            Console.WriteLine("Update block for mysql server");
        }
        public void Delete()
        {
            Console.WriteLine("Delete block for mysql server");
        }
    }

    class SqlServerDal : IPersonDal
    {
        public void Add()
        {
            Console.WriteLine("Add block for sql server");
        }
        public void Update()
        {
            Console.WriteLine("Update block for sql server");
        }
        public void Delete()
        {
            Console.WriteLine("Delete block for sql server");
        }
    }

    class OtherServerDal : IPersonDal
    {
        public void Add()
        {
            Console.WriteLine("Add block for otherServer");
        }
        public void Update()
        {
            Console.WriteLine("Update block for otherServer");
        }
        public void Delete()
        {
            Console.WriteLine("Delete block for otherServer");
        }
    }

    class DalManager
    {
        public void Add(IPersonDal person)
        {
            person.Add();
        }

        public void Update(IPersonDal person)
        {
            person.Update();
        }

        public void Delete(IPersonDal person)
        {
            person.Delete();
        }

    }

}