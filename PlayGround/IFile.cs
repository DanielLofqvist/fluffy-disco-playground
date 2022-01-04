using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround
{
    interface IFile
    {

        void ReadFile();
        void WriteFile();
        //{
        //    Console.WriteLine(text);
        //}
    }





    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing to file");
        }


    }


    public class implementationOfIFile : IFile
    {

        public void WriteFile()
        {

        }


        public void ReadFile()
        {


        }
    }



}
