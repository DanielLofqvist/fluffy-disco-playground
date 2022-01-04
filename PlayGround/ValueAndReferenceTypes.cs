using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround
{
    class ValueAndReferenceTypes
    {
        //VALUE TYPES
        public static class WriteStaticNumber
        {
            public static int ReturnInt(int i)
            {
                return i + 200;
            }
        }

        public class WritePublicNumber
        {
            public int ReturnInt(int i)
            {
                return i + 200;
            }
        }
        //VALUE TYPES STOP

    

    //REFERENCE TYPE



        public class ReferenceStudent
        {
            public string NameOfStudent { get; set; }
            public int AgeOfStudent { get; set; }

            public static void ChangeReferenceType(ReferenceStudent referenceStudent)
            {
                referenceStudent.NameOfStudent = "James";
                referenceStudent.AgeOfStudent = 33;
            }
        }





        public static class MethodExecution
        {

            public static void ValueTypeExecutionMethod()
            {
                int i = 100;
                Console.WriteLine(i);
                var someInt = WriteStaticNumber.ReturnInt(i);
                Console.WriteLine(someInt);
                Console.WriteLine(i);

                Console.WriteLine();

                Console.WriteLine("PUBLIC INT");
                WritePublicNumber writePublicNumber = new WritePublicNumber();
                Console.WriteLine(i);
                var somePublicInt = writePublicNumber.ReturnInt(i);
                Console.WriteLine(somePublicInt);
                Console.WriteLine(i);

            }



            public static void ReferenceTypeExecutionMethod()
            {
                ReferenceStudent referenceStudent = new ReferenceStudent();
                Console.WriteLine("Value not set = null " + referenceStudent.NameOfStudent);
                Console.WriteLine("Value not set = null " + referenceStudent.AgeOfStudent);
                referenceStudent.NameOfStudent = "Nicklas";
                referenceStudent.AgeOfStudent = 10;

                Console.WriteLine("Before reference change " + referenceStudent.NameOfStudent);
                Console.WriteLine("Before reference change " + referenceStudent.AgeOfStudent);

                ReferenceStudent.ChangeReferenceType(referenceStudent);

                Console.WriteLine("After reference change " + referenceStudent.NameOfStudent);
                Console.WriteLine("After reference change " + referenceStudent.AgeOfStudent);


                var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            }









        }





    












}
}
