using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_offline
{
    /// <summary>
    /// Интерфейс пользователя.
    /// </summary>
    internal class UI
    {
        /// <summary>
        /// Приветствие.
        /// </summary>
        public static void PrintHeader()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine(new string('=', 50));
        }

        /// <summary>
        /// Запрос зарегистрирован ли пользователь.
        /// </summary>
        public static void PrintRequestIfUserRegistered()
        {
            Console.Write("Вы уже запегистрированы?\n" +
                "Если да, нажмите Y, если нет - нажмите N:\t");
        }

        /// <summary>
        /// Ошибка, не правильно выбрано значение.
        /// </summary>
        public static void PrintChoiseError()
        {
            Console.WriteLine("\nНе правильно выбрано значение.");
        }

        /// <summary>
        /// Запрос логина.
        /// </summary>
        public static void PrintLoginRequest()
        {
            Console.Write("\nВведите логин:\t");
        }

        /// <summary>
        /// Запрос пароля.
        /// </summary>
        public static void PrintPassRequest()
        {
            Console.Write("\nВведите пароль. " +
                "Только цифры, длина - 6 символов.:\t");
        }

        /// <summary>
        /// Печать ошибки о неправильном логине.
        /// </summary>
        public static void PrintLoginError()
        {
            Console.WriteLine("\nНе правильно введен логин. " +
                "Должны быть только буквы. И не менее 6 символов");
        }


        /// <summary>
        /// Печать ошибки о неправильном логине.
        /// </summary>
        public static void PrintPassError()
        {
            Console.WriteLine("\nНе правильно введен пароль. " +
                "Только цифры, длина - 6 символов.");
        }
    }
}
