﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_ParametrizedConstructor
{
    class Person
    {
        string name;
        int    age;
        public void PrintValues() { Console.WriteLine($"{name}, {age}"); }
        //Deafult
       public Person()
        {
            name = "Nazar Al-Wattar";
            age = 25;

        }
        //Parametrized Constructor
       public Person(string name)
        {
            this.name = name;
            age = 30;

        }
        //Parametrized Constructor
      public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
 /*  
  
 for more information visit
          http://www.youtube.com/c/AToZForLearning 
		  
Visit our channel page on facebook
          https://www.facebook.com/AToZForLearning/

If you have any question in English or Arabic welcome to our facebook group 
          https://www.facebook.com/groups/AToZForLearningProgramming/  
			  
		  
		  */


        }


    }
}
