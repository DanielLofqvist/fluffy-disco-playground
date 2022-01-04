using System;
using static PlayGround.ValueAndReferenceTypes;

namespace PlayGround
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text.RegularExpressions;
    using DataContractSerializerExample;

    class Program
    {
        static void Main(string[] args)
        {

            ////VALUE TYPES
            //MethodExecution.ValueTypeExecutionMethod();

            //Console.WriteLine();
            ////REFERENCE TYPE
            //MethodExecution.ReferenceTypeExecutionMethod();

            //Console.WriteLine();
            ////DynamicType that changes through out the execution
            //DynamicType.ValuesForDynamicVar();

            //This will crash
            //DynamicType.ClassAsDynamicType();


            //FileInfo file = new FileInfo();
            //file.WriteFile();


            //Server.StartServer();

            //Test.ReadObject("somename");

            //Test.DataContract();
            //list from outlook
            string test =
                "< test.test@test.com >;";

            var authenticatedUsers = new List<string>
            {
               "emails"
            };

            var program = new Program();
            program.GetAddresses(authenticatedUsers);
            Console.WriteLine();
            Console.WriteLine();
            program.GetAddressesFromString(test);
        }

        public void GetAddressesFromString(string test)
        {
            var regexPlain = new Regex("\\w*(?<!\\.\\w*)\\.\\w*@\\w*\\.\\w{3}");
            var regexWithHyphen = new Regex("(\\w*\\.\\w*\\-\\w*@\\w*\\.\\w{3})");
            var regexWithMoreDots = new Regex("(\\w*\\.\\w*\\.\\w*@\\w*\\.\\w{3})");
            var plainList = regexPlain.Matches(test).ToList();
            var withBindeStreck = regexWithHyphen.Matches(test).ToList();
            var withMoreDots = regexWithMoreDots.Matches(test).ToList();

            var testList = plainList.Concat(withBindeStreck).
                                     Concat(withMoreDots).
                                     Select(a => a.Value).
                                     ToList();
            testList.Sort();
            testList.ForEach(a => Console.WriteLine('"' + a.ToLower() + '"' + ','));

            //foreach (var item in testList)
            //{
            //    var testing = '"' + item + '"' + ',';
            //    Console.WriteLine(testing.ToLower());
            //}
  
            Console.WriteLine($"Count of GetAddressesFromString is: {testList.Count}");

        }

        public void GetAddresses(List<string> adresses)
        {

            adresses.Sort();
            var newAdressList = new List<string>();

            foreach (var item in adresses)
            {
                var test = '"' + item + '"' + ',';

                newAdressList.Add(test);
            }

            foreach (var item in newAdressList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count of GetAddresses is: {newAdressList.Count}");
        }




    }
}
