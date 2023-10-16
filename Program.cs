// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

public class Calculator
{
    public double Sum(double number, double moreNumber)
    {
        return number + moreNumber;
    }

    public double Multiply(double number, double moreNumber)
    {
        return number * moreNumber;
    }

    public double Subtraction(double number, double moreNumber)
    {
        return number - moreNumber;
    }

    public double Division(double number, double moreNumber)
    {
        return number / moreNumber;
    }
}

public class Requester
{
    Calculator cal;
    public Requester(Calculator cal)
    {
        this.cal = cal;
    }

    public void Request()
    {
        bool check = true;
        double result = 0;
        while (check == true)
        {

            Console.WriteLine("Введите первое число");
            double number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Выберите метод");
            string method = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            double moreNumber = Convert.ToInt64(Console.ReadLine());

            switch (method)
            {
                case "+":
                    result = cal.Sum(number, moreNumber);
                    Console.WriteLine(result);
                    break;

                case "*":
                    result = cal.Multiply(number, moreNumber);
                    Console.WriteLine(result);
                    break;

                case "-":
                    result = cal.Sub(number, moreNumber);
                    Console.WriteLine(result);
                    break;

                case "/":
                    result = cal.Div(number, moreNumber);
                    if (moreNumber != 0)
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("на 0 делить нельзя");
                    }
                    break;
            }
            number = result;

            Console.WriteLine("Продолжить?");
            string question = Console.ReadLine();
            if (question == "Yes") { }
            else if (question == "No")
            {
                Console.WriteLine("Очистить калькулятор?");
                string moreQuestion = Console.ReadLine();
                if (moreQuestion == "Yes")
                {
                    Console.WriteLine("");
                    Console.ReadKey();
                    check = false;
                }
            }
            else
            {
                Console.WriteLine("Вы не ответили на вопрос");
            }

        }

    }
}

public class Program
{
    static void Main()
    {
        Calculator cal = new Calculator();
        Requester simp = new Requester(cal);
        simp.Request();
    }
}
