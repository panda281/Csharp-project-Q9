using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q9
{
    public class employees
    {
        static int id = 27560000;
        string _first_name;
        string _last_name;
        int _age;
        char _gender;
        int _id;

        public employees(string first_name, string last_name, int age,char gender)
        {
            this._first_name = first_name;
            this._last_name = last_name;
            this._age = age;
            this._gender = gender;
            _id = id;

            id++;
        }

        //public string View_firstname()
        //{
        //    return this._first_name;
        //}
        //public string View_lastname()
        //{
        //    return this._last_name;
        //}
        //public int View_age()
        //{
        //    return this._age;
        //}
        //public char View_gender()
        //{
        //    return this._gender;
        //}
        //public int View_id()
        //{
        //    return _id;
        //}

    }
    class Program
    {

        static void Main(string[] args)
        {
            //employees emp1 = new employees("abinet","tamiru",21,'m');
            //employees emp2 = new employees("abel", "t", 21, 'm');
            //Console.WriteLine("first name: {0}", emp1.View_firstname());
            //Console.WriteLine("last name: {0}", emp1.View_lastname());
            //Console.WriteLine("age : {0}", emp1.View_age());
            //Console.WriteLine("gender: {0}", emp1.View_gender());
            //Console.WriteLine("id: {0}", emp1.View_id());


            //Console.WriteLine("first name: {0}", emp2.View_firstname());
            //Console.WriteLine("last name: {0}", emp2.View_lastname());
            //Console.WriteLine("age : {0}", emp2.View_age());
            //Console.WriteLine("gender: {0}", emp2.View_gender());
            //Console.WriteLine("id: {0}", emp2.View_id());


        }
    }
}
