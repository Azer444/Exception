using System;
using System.Collections.Generic;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MailPassword
            //List<string> checklist = new List<string>();

            //checklist.Add("Azer");
            //checklist.Add("Huseyn");
            //checklist.Add("Eli");
            //checklist.Add("Maqa");

            //string searchText = "Azer";
            //CheckString(checklist, searchText);
            //#endregion

            //#region CustomExceptionMethod(1)

            //LoginException("Azerrh@code.edu.az", "Necesen567);

            //#endregion

            //#region CustomExceptionMethod(2)

            //List<string> listUsername = new List<string>() { "Azer123", "Azerrh", "Azerrh123"  };

            //List<string> listPassword = new List<string>() { "Necesen", "NevarNeyox", "Salamatclqdi", "BahsqaNevarNeyox" };

            //string searchUsername = "Azerrh@code.edu.az";

            //string searchPassword = "Necesen567";

            //LoginException(listUsername, searchUsername, listPassword, searchPassword);

            #endregion




        }

        #region MailPassword

        //public static void CheckString(List<string> names, string name)
        //{
        //    try
        //    {
        //        var data = names.Find(m => m == name);
        //        if (data is null) throw new CheckString("Not Found Name");
        //        Console.WriteLine("Doğrudur");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}
        #endregion

        #region Exception

        //public static void LoginException(string username, string password)
        //{
        //    try
        //    {
        //        if (username == "Azerrh@code.edu.az" && password == "Necesen567")
        //        {
        //            throw new Login("Enter");

        //        }
        //        else
        //        {
        //            Console.WriteLine("Error");
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //}
        #endregion

        #region Exception

        //public static void LoginException(List<string> username, string user, List<string> password, string pass)
        //{
        //    try
        //    {
        //        if (!username.Contains(user) && !password.Contains(pass))
        //        {
        //            throw new Login("Error");
        //        }

        //        var data = username.Find(m => m == user);
        //        var data1 = password.Find(m => m == pass);

        //        if (data is null && data1 is null) throw new Login("Error");

        //        Console.WriteLine("Entered");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}

        #endregion

    }
}

