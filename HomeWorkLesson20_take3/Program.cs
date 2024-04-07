int addition(int firstParameter, int secondParameter) 
{
    int result = firstParameter | secondParameter;
    return result;
    }
int multiplicatior(int firstParameter, int secondParameter) 
{
    int result = firstParameter & secondParameter;
    return result;
    }
int negation(int firstParameter) 
{
    int result = ~firstParameter;
    return result;
    }
int exception(int firstParameter, int secondParameter) 
{
    int result = firstParameter ^ secondParameter;
    return result;
}
Console.Write("Введите первое число:");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int num2=int.Parse(Console.ReadLine());
Console.Write("Выберете операцию:\n1.Логичекое сложение.\n2.Логическое умножение.\n3.Логическое отрицание.\n4.Логиеское исключение.\n");
int userChoice=int.Parse(Console.ReadLine());
switch(userChoice)
{
    case 1:
        Console.Write(addition(num1,num2));
        break;
    case 2:
        Console.Write(multiplicatior(num1, num2));
        break;
    case 3:
        { Console.Write(negation(num1));
            Console.Write(negation(num2));
        } break;
    case 4:
        Console.Write(exception(num1,num2));
        break;
    default:
        Console.WriteLine("Такого варианта нет!");
        break;
}