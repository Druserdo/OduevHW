﻿Console.WriteLine($"Выберете аромат:\n1.Shanel\n2.Dior\n3.Tom Ford\n4.Gucci\n5.Yves Saint Laurent");
int userChoice=int.Parse( Console.ReadLine() );
switch(userChoice)
{
    case 1: Console.WriteLine("Гордая и страстная Габриэль Шанель была в полной мере воплощением своего знака Зодиака. Интуитивная и смелая, она находила в нем вдохновение. Лев стал ее тотемным животным. Мощные и чувственные амбровые кожаные ноты лабданума звучат мягче на фоне ванили и бергамота, словно подсвечиваются ими. LE LION DE CHANEL – это теплая, величественная и утонченная композиция.");break;
    case 2: Console.WriteLine("Окутанная тайной коллекция прет-а-порте Dior весна-лето 2024 воплощает в себе бунтарское изящество. Образы, исполненные многогранной элегантности, в которых простота объединяется с изысканностью, рассказывают историю об истинном освобождении: ткани, которые господин Диор называл единственным средством выражения мечты, наполняются волшебством, воплощая в себе творческое воображение и обретая все новые интерпретации. Это прекрасное посвящение всем граням женственности.");break;
    case 3: Console.WriteLine("Ныне знаменитый дизайнер и парфюмер Том Форд родился в самом сердце США, в штате Техас. Его семья много путешествовала по стране, детство Том провел в Санта-Фе, а позднее переехал в Нью-Йорк, где и начал определяться со своим будущим. Обладая проницательным умом, уверенностью в себе и будучи амбициозным молодым человеком, он начал изучать историю искусств, но это ему вскоре надоело. Воспользовавшись тем, что он отлично рисует, Том бросил Нью-Йоркский университет и перешел на архитектурное отделение в знаменитой Парсонской школе. Студенты часто бывали в Париже на разных семинарах. Вероятно, это и стало ключом к тому, что карьера Тома Форда пошла на рост в Европе, а не в США.");break;
     case 4: Console.WriteLine("это аромат для женщин, он принадлежит к группе восточные цветочные. Gucci Guilty выпущен в 2010 году. Парфюмер: Aurelien Guichard. Верхние ноты: Розовый перец, Мандарин и Бергамот; средние ноты: Сирень, Персик, Герань, Жасмин и Черная смородина; базовые ноты: Пачули, Амбра, Белый мускус и Ваниль.");break;
     case 5: Console.WriteLine("это аромат для женщин, он принадлежит к группе восточные цветочные. Cinéma выпущен в 2004 году. Парфюмер: Jacques Cavallier. Верхние ноты: Цветок миндаля, Клементин и Цикламен; средние ноты: Жасмин, Пион и Амариллис; базовые ноты: Ваниль, Амбра, Бензоин и Белый мускус.");break;
}