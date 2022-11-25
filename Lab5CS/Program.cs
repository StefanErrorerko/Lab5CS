using System;
using System.Text.RegularExpressions;

namespace CSLab5
{
    class Program
    {
        static void Main(String[] args)
        {
            var name = "Andrii";
            var surname = "Iarmolenko";
            var patronymic = "Batkovych";
            var ampoule = Ampoule.Forward;
            var salary = (Decimal)50000;

            var somePlayer1 = CreateFootballPlayer(name, surname, patronymic, ampoule, salary);
            if (somePlayer1 != null)
            {
                ShowPlayer(somePlayer1);
            }
            else
            {
                ShowError();
            }

            //невiрне iм'я
            name = "Sh/o";
            surname = "Ivanenko";
            patronymic = "Ivanovych";
            ampoule = Ampoule.Defender;
            salary = (Decimal)1000;

            var somePlayer2 = CreateFootballPlayer(name, surname, patronymic, ampoule, salary);
            if (somePlayer2 != null)
            {
                ShowPlayer(somePlayer2);
            }
            else
            {
                ShowError();
            }

            name = "Andrii";
            surname = "Pyatov";
            patronymic = "Tatovych";
            salary = (Decimal)10000;
            var missedGoals = 15;

            var somePlayer3 = CreateFootballPlayer(name, surname, patronymic, salary, missedGoals);
            if (somePlayer3 != null)
            {
                ShowPlayer(somePlayer3);
            }
            else
            {
                ShowError();
            }

            name = "Ostap";
            surname = "Bykoriz";
            patronymic = "Petrovych";
            salary = (Decimal)(-5000);
            missedGoals = 10;

            var somePlayer4 = CreateFootballPlayer(name, surname, patronymic, salary, missedGoals);
            if (somePlayer4 != null)
            {
                ShowPlayer(somePlayer4);
            }
            else
            {
                ShowError();
            }

        }

        static FootballPlayer? CreateFootballPlayer(
            String name, String surname, String patronymic, Ampoule position, Decimal salary)
        {
            if (name == null || !Regex.IsMatch(name, @"^[A-z,a-z]+$"))
            {
                return null;
            }
            if (surname == null || !Regex.IsMatch(name, @"^[A-z,a-z]+$"))
            {
                return null;
            }
            if (patronymic == null || !Regex.IsMatch(name, @"^[A-z,a-z]+$"))
            {
                return null;
            }
            if (salary < 0)
            {
                return null;
            }

            return new FootballPlayer(name, surname, patronymic, position, salary);
        }

        static FootballPlayer? CreateFootballPlayer(
            String name, String surname, String patronymic, Decimal salary, int missedGoals)
        {
            if (name == null || !Regex.IsMatch(name, @"^[A-z,a-z]+$"))
            {
                return null;
            }
            if (surname == null || !Regex.IsMatch(name, @"^[A-z,a-z]+$"))
            {
                return null;
            }
            if (patronymic == null || !Regex.IsMatch(name, @"^[A-z,a-z]+$"))
            {
                return null;
            }
            if (salary < 0)
            {
                return null;
            }
            if (missedGoals < 0)
            {
                return null;
            }

            return new GoalKeeper(name, surname, patronymic, salary, missedGoals);
        }

        static void ShowPlayer(FootballPlayer somePlayer)
        {
            Console.WriteLine($"Гравець: {somePlayer.Name}, {somePlayer.Surname}, {somePlayer.Patronymic}");
            Console.WriteLine("Амплуа: {0}", somePlayer.Position.ToString());
            Console.WriteLine("Зарплатня: {0}", somePlayer.Salary);
            if(somePlayer.GetType() == typeof(GoalKeeper))
            {
                var goalKeeper = (GoalKeeper)somePlayer;
                Console.WriteLine("Пропущено м'ячiв: {0}", goalKeeper.n);
            }
            Console.WriteLine();
        }
        
        static void ShowError()
        {
            Console.WriteLine("Невiрнi данi.");
            Console.WriteLine();
        }
    }

}