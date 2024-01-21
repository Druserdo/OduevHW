////////Console.WriteLine("Hi");
////////int result = 2 + 2;
////////Console.WriteLine(result);
////////Console.WriteLine(result.ToString());
////////Console.WriteLine(int.Parse(result.ToString()));

////////take 1
//////Console.WriteLine("Введиче первое число:");
//////int first= int.Parse(Console.ReadLine());
//////Console.WriteLine("Введиче второе число:");
//////int second= int.Parse(Console.ReadLine());
//////Console.WriteLine($"{first}+{second}={first+second}")
////Console.WriteLine("Укажите имя:");
////string name = Console.ReadLine();

////Console.WriteLine("Укажите фамилию:");
////string surName = Console.ReadLine();

////Console.WriteLine("Введите возраст:");
////int age = int.Parse(Console.ReadLine());

////string result = $"Привет {name} {surName} тебе {age} года";
////Console.WriteLine(result);
////Console.WriteLine("20/01/2024");
//////Создание конкретной даты
////DateTime date = new DateTime(2024, 01, 20);//задать дату
////DateTime currentDate = DateTime.Now;
////Console.WriteLine($"{date}");
////Console.WriteLine($"{currentDate}");

//Console.WriteLine("Укажите ваше имя:");
//string name = Console.ReadLine();

//Console.WriteLine("Укажите вашу фамилию:");
//string surName = Console.ReadLine();

//Console.WriteLine("Введите ваш возраст:");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Имя вашей собаки:");
//string nameDog= Console.ReadLine();

//Console.WriteLine("Фамилия вашей собаки");
//string surNameDog= Console.ReadLine();

//Console.WriteLine("Возраст вашей собаки:");
//int ageDog = int.Parse(Console.ReadLine());

//Console.WriteLine("Порода вашей собаки:");
//string breed = Console.ReadLine();

//Console.WriteLine("Где вы обычно гуляете:");
//string faworitePlace= Console.ReadLine();

//Console.WriteLine("Сколько времени в минутах занимает прогулка?");
//int walkingTime = int.Parse(Console.ReadLine());


//Console.WriteLine("Вы любите вашу собаку? Да/Нет");
//string love = Console.ReadLine();

//Console.WriteLine($"Привет {name}, твоя фамилия {surName},тебе {age} лет.\nТвою собаку зовут {nameDog},ее фамилия {surNameDog}, твоей собаке {ageDog} и ее ворода {breed}.\nВы любите гулять в {faworitePlace}.Это занимает {walkingTime}.На вопрос \"Любите вы свою собаку?\" ты ответил {love}");

//Первый продукт

const string ADDRESS = "г.Калмнмнград ул.Шмудлера д.5";
DateTime currentDate = DateTime.Now;
const string ORGANIZATIONNAME = "OOO\"Семейный магазин\"";
const string CHECKLIST = "Название\tЦена\t\tКол-во\t\tСумма\n\n*****************************************************\n\n";

//Первый продукт
Console.Write("Укажите продукт:");
string firstProductName = Console.ReadLine();

Console.Write($"Укажите цену продукта {firstProductName}:");
string firstProductPrise = Console.ReadLine();

Console.Write($"Укажите количетво продукта {firstProductName}:");
string firstProductQuantity = Console.ReadLine();

int firstTotal = int.Parse(firstProductPrise) * int.Parse(firstProductQuantity);

//Второй продукт

Console.Write("Укажите продукт:");
string secondProductName = Console.ReadLine();

Console.Write($"Укажите цену за продукт  {secondProductName}:");
string secondProductPrise = Console.ReadLine();

Console.Write($"Укажите количетво продукта {secondProductName},:");
string secondProductQuantity = Console.ReadLine();

int secondTotal = int.Parse(secondProductPrise) * int.Parse(secondProductQuantity);

//Третий продукт

Console.Write("Укажите продукт:");
string thirdProductName = Console.ReadLine();

Console.Write($"Укажите цену за продукт {thirdProductName}:");
string thirdProductPrise = Console.ReadLine();

Console.Write($"Укажите количетво продукта {thirdProductName},:");
string thirdProductQuantity = Console.ReadLine();

int thirdTotal = int.Parse(thirdProductPrise) * int.Parse(thirdProductQuantity);

//Четвертый продукт

Console.Write("Укажите продукт:");
string fourthProductName = Console.ReadLine();

Console.Write($"Укажите цену за продукт {fourthProductName}:");
string fourthProductPrise = Console.ReadLine();

Console.Write($"Укажите количетво продукта {fourthProductName}, по цене {fourthProductPrise}:");
string fourthProductQuantity = Console.ReadLine();

int fourthdTotal = int.Parse(fourthProductPrise) * int.Parse(fourthProductQuantity);

int totalAmount = firstTotal + secondTotal + thirdTotal + firstTotal;
//чек
Console.WriteLine($"\t{ORGANIZATIONNAME}\n\t{ADDRESS}\n\t{currentDate}\n{CHECKLIST}");
Console.WriteLine($"{firstProductName}\t\t{firstProductPrise}\t\t{firstProductQuantity}\t\t{firstTotal}\n{secondProductName}\t\t{secondProductPrise}\t\t{secondProductQuantity}\t\t{secondTotal}\n{thirdProductName}\t\t{thirdProductPrise}\t\t{thirdProductQuantity}\t\t{thirdTotal}\n{firstProductName}\t\t{firstProductPrise}\t\t{firstProductQuantity}\t\t{firstTotal}\n\n*****************************************************\n\n\t\tИТОГ:\t\t\t\t{totalAmount}\a");