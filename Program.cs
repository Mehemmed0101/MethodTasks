namespace MethodTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region NumberTasks
            var number = new NumberTasks();
            int n = number.EnterNumber();
            number.Print(n);
            #endregion
            #region ArrayTasks
            var mass = new ArrayTasks();
            int[] x = mass.SqrtArray();
            mass.Print(x);
            #endregion

        }

    }
}