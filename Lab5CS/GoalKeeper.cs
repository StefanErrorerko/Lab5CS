namespace CSLab5
{
    public class GoalKeeper : FootballPlayer
    {

        // goals missed
        public Int32 n { get; private set; }
        public GoalKeeper(String name, String surname, String patronymic, decimal salary, int n)
            : base(name, surname, patronymic, Ampoule.Goalkeeper, salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = Ampoule.Goalkeeper;
            Salary = salary;
            this.n = n;
        }

        public override void SalaryChange()
        {
            Salary /= n;
        }
    }
}
