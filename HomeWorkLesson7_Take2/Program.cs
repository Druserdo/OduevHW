Console.WriteLine("Укажите ваше имя:");
string name = Console.ReadLine();

Console.WriteLine("Укажите вашу фамилию:");
string surName = Console.ReadLine();

Console.WriteLine("Введите ваш возраст:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Имя вашей собаки:");
string nameDog = Console.ReadLine();

Console.WriteLine("Фамилия вашей собаки");
string surNameDog = Console.ReadLine();

Console.WriteLine("Возраст вашей собаки:");
int ageDog = int.Parse(Console.ReadLine());

Console.WriteLine("Порода вашей собаки:");
string breed = Console.ReadLine();

Console.WriteLine("Где вы обычно гуляете:");
string faworitePlace = Console.ReadLine();

Console.WriteLine("Сколько времени в минутах занимает прогулка?");
int walkingTime = int.Parse(Console.ReadLine());


Console.WriteLine("Вы любите вашу собаку? Да/Нет");
string love = Console.ReadLine();

Console.WriteLine($"Привет {name}, твоя фамилия {surName},тебе {age} лет.\nТвою собаку зовут {nameDog},ее фамилия {surNameDog}, твоей собаке {ageDog} и ее ворода {breed}.\nВы любите гулять в {faworitePlace}.Это занимает {walkingTime}.На вопрос \"Любите вы свою собаку?\" ты ответил {love}");
