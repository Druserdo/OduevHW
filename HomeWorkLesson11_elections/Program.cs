﻿//Console.Write("Введите ваш возраст:");
//byte ageUser=byte.Parse(Console.ReadLine());
//Console.WriteLine("За кого вы будете болеть если проиграете или не будете допущены к выборам?\n1.Незнайка\n2.Лунтик\n3.Карлсон\n4.Дядя Федор");
//byte candidate = byte.Parse(Console.ReadLine());
//switch(candidate)
//{
//    case 1:Console.WriteLine("А у тебя в животе арбуз вырастет!");break;
//    case 2:Console.WriteLine("Я родился!");break;
//    case 3:Console.WriteLine("Спокойствие, только спокойтвие!");break;
//    case 4:Console.WriteLine("Чтобы продать чтонибудь ненужное, надо сначала купить что-нибудь ненужное, а у нас денег нет.");break;
//}
//if (ageUser < 18)
//    Console.WriteLine("Вы слишком молоды для участия в выборах!");
//else if (ageUser >= 18 && ageUser <= 35)
//     Console.WriteLine("Вы можете участвовать в выборах в качестве депутата!");
//     else if (ageUser > 35 && ageUser <= 65)
//     Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
//          else if (ageUser > 65 )
//          Console.WriteLine("Ваш возраст слишком велик для участия в выборах");
//2
Random rand = new Random();
int monthPC = rand.Next(1, 13);
string monthNamePc = "";
switch(monthPC)
{
        case 1:monthNamePc = "Январь"; break;
        case 2:monthNamePc = "Февраль"; break;
        case 3:monthNamePc = "Март"; break;
        case 4:monthNamePc = "Апрель"; break;
        case 5:monthNamePc = "Май"; break;
        case 6:monthNamePc = "Июнь"; break;
        case 7:monthNamePc = "Июль"; break;
        case 8:monthNamePc = "Август"; break;
        case 9:monthNamePc = "Сентябрь"; break;
        case 10:monthNamePc = "Октябрь"; break;
        case 11:monthNamePc = "Ноябрь"; break;
        case 12:monthNamePc = "Декабрь"; break;
}
Console.Write(monthNamePc);