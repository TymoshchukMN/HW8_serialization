using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_offline
{
    internal class Starter
    {
        public static void Run()
        {
            UI.PrintHeader();
            UI.PrintRequestIfUserRegistered();

            ConsoleKey selectedVol = Console.ReadKey(true).Key;

            if (!Validator.CheckUsersInput(selectedVol))
            {
                do
                {
                    UI.PrintChoiseError();
                    UI.PrintRequestIfUserRegistered();
                    selectedVol = Console.ReadKey(true).Key;
                }
                while (!Validator.CheckUsersInput(selectedVol));
            }

#pragma warning disable CS8600
            UI.PrintLoginRequest();

            string userLogin = Console.ReadLine();

            if (!Validator.CheckInputedLogin(userLogin))
            {
                UI.PrintLoginError();
                do
                {
                    UI.PrintLoginRequest();

                    userLogin = Console.ReadLine();
                }
                while (!Validator.CheckInputedLogin(userLogin));
            }

            UI.PrintPassRequest();
            string userPass = Console.ReadLine();

            if (!Validator.CheckInputedPass(userPass))
            {
                do
                {
                    UI.PrintPassError();
                    UI.PrintPassRequest();
                }
                while (Validator.CheckInputedPass(userPass));
            }

            Handler.RunRegistration(new User(userLogin, userPass));


#pragma warning restore CS8600
        }
    }
}
