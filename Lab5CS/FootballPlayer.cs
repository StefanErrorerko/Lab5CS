using System.Text.RegularExpressions;

namespace CSLab5
{
    public enum Ampoule
    {
        Forward,
        Middefender,
        Defender,
        Goalkeeper
    };

    public class FootballPlayer
    {
        private String name;
        private String surname;
        private String patronymic;
        private Ampoule position;
        private Decimal salary;

        public String Name {
            get
            {
                return name;
            }
            init
            {
                if (value == null || !Regex.IsMatch(value, @"^[A-z,a-z]+$"))
                {
                    throw new InvalidDataException();
                }
                name = value;
            }
        }
        public String Surname {
            get
            {
                return surname;
            }
            init
            {
                if (value == null || !Regex.IsMatch(value, @"^[A-z,a-z]+$"))
                {
                    throw new InvalidDataException();
                }
                surname = value;
            }
        }
        public String Patronymic {
            get
            {
                return patronymic;
            }
            init
            {
                if (value == null || !Regex.IsMatch(value, @"^[A-z,a-z]+$"))
                {
                    throw new InvalidDataException();
                }
                patronymic = value;
            }
        }
        public Ampoule Position
        {
            get
            {
                return position;
            }
            protected set
            {
                position = value;
            }
        }
        public Decimal Salary {
            get
            {
                return salary;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new InvalidDataException();
                }
                salary = value;
            }
        }

        public FootballPlayer(String name, String surname, String patronymic, Ampoule position, Decimal salary)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.position = position;
            this.salary = salary;
        }
        public virtual void SalaryChange() { }
    }
}
