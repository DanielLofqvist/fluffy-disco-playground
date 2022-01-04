using System;
using System.Collections.Generic;
using System.Text;
using static PlayGround.ValueAndReferenceTypes;

namespace PlayGround
{
    class DynamicType
    {

        public static void ValuesForDynamicVar()
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
        }



        public static void ClassAsDynamicType()
        {
            dynamic student = new ReferenceStudent();

            student.DisplayStudentInfo(1, "Bill");// run-time error, no compile-time error
            student.DisplayStudentInfo("1");// run-time error, no compile-time error
            student.FakeMethod();// run-time error, no compile-time error
        }



    }
}
