using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW8_offline
{
    internal class Validator
    {
        /// <summary>
        /// Проверка введенных пользователем данных.
        /// </summary>
        /// <param name="key">Значение, введенное в консоли.</param>
        /// <returns>true - введенное значение корректно.</returns>
        public static bool CheckUsersInput(ConsoleKey key)
        {
            bool isCorrect = false;

            switch (key)
            {
                case ConsoleKey.N:
                    isCorrect = true;
                    break;

                case ConsoleKey.Y:
                    isCorrect = true;

                    break;
                default:
                    break;
            }

            return isCorrect;
        }

        /// <summary>
        /// Проверка введенного логина.
        /// </summary>
        /// <param name="inputedLogin">Логин от пользователя.</param>
        /// <returns>true - кореектный. false - не корректный.</returns>
        public static bool CheckInputedLogin(string inputedLogin)
        {
            const int MinLoginLenth = 6;
            const string pattern = "^[a-zA-Z]+$";

            if (inputedLogin.Length < MinLoginLenth)
            {
                return false;
            }

            Regex regex = new Regex(pattern);

            return regex.IsMatch(inputedLogin);
        }

        /// <summary>
        /// Проверка введенного пароля.
        /// </summary>
        /// <param name="inputedPass">Пароль от пользователя.</param>
        /// <returns>true - кореектный. false - не корректный.</returns>
        public static bool CheckInputedPass(string inputedPass)
        {
            const int PassLenth = 6;
            if (inputedPass.Length != PassLenth)
            {
                return false;
            }

            const string pattern = "^[0-9]+$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(inputedPass);
        }
    }
}
