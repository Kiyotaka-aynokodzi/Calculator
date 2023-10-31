// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

public class Calculator
{
    public double Addition(double number, double moreNumber)
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
        int data = 1;
        bool check = true;
        double result = 0;
        while (check == true)
        {

            Console.WriteLine("Введите первое число");
            double number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Выберите метод");
            string methods = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            double moreNumber = Convert.ToInt64(Console.ReadLine());

            if (methods == "/")
            {
                result = cal.Division(number, moreNumber);
                Console.WriteLine(result);
            }
            else if (methods == "+")
            {
                result = cal.Addition(number, moreNumber);
                Console.WriteLine(result);
            }
            else if (methods == "-")
            {
                result = cal.Subtraction(number, moreNumber);
                Console.WriteLine(result);
            }
            else if (methods == "*")
            {
                result = cal.Multiply(number, moreNumber);
                Console.WriteLine(result);
            }
            number = result;

            Console.WriteLine("Продолжить?");
            string question = Console.ReadLine();
            if (question == "Yes")
            {
                data = 0;
                if(data < 1)
                {
                    Console.WriteLine(result);
                    data++;
                }
            }
            else if (question == "No")
            {
                Console.WriteLine("Очистить калькулятор?");
                string moreQuestion = Console.ReadLine();
                if (moreQuestion == "Yes")
                {
                    Console.WriteLine("пока");
                    Console.ReadKey();
                    check = false;
                } else if(moreQuestion == "No"){
                    check = false;
                    data = 0;
                    if(data <= 1) {
                        Console.WriteLine(result);
                    }
                    Console.WriteLine("пока");
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
        bool proverka = true;
        while (proverka == true)
        {
            Calculator cal = new Calculator();
            Requester Request = new Requester(cal);
            Request.Request();
        }
    }
}
