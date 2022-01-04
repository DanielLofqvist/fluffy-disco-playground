using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround
{
    class TupleCreator
    {

        public void ReturnTuple()
        {

            var helloWithBanana = new Tuple<bool, string, string>(true, "hello", "banana");

            var person = Tuple.Create(1, 2, "FirstName", "LastName");

            Console.WriteLine($"{person.Item1}, {person.Item2}");

            // nested tuple
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15,16,17,18,19,20,21,Tuple.Create(22,23,24,25,26,27,28))));
           
            
            ValueTuple<int, string, string> person2 = (1, "Bill", "Gates");

            var billGates = (1, "bill", "gates");



        }



    }
}
