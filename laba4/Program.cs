// See https://aka.ms/new-console-template for more information

using laba4;



Service Service1 = new Service();
Service Service2 = new Service();

List<object> services = new List<object> { Service1, Service2 };

ConsoleReporting reporting = new ConsoleReporting();

Random rnd = new Random();
for (int i = 0; i < 2; i++)
{
    Service s = new Service();
    int k = rnd.Next(4);
    switch (k)
    {
        case 0:
            s.Id = rnd.Next(10000, 99999);
            break;
        case 1:
            s.Id = rnd.Next(10000, 99999);
            break;
        case 2:
            s.Id = rnd.Next(10000, 99999);
            break;
        case 3:
            s.Id = rnd.Next(10000, 99999);
            break;
    }
    k = rnd.Next(4);
    switch (k)
    {
        case 0:
            s.Title = "Мойка";
            break;
        case 1:
            s.Title = "Сушка";
            break;
        case 2:
            s.Title = "Выжимка";
            break;
        case 3:
            s.Title = "Eco";
            break;
    }
    k = rnd.Next(4);
    switch (k)
    {
        case 0:
            s.Description = "Описание 1";
            break;
        case 1:
            s.Description = "Описание 2";
            break;
        case 2:
            s.Description = "Описание 3";
            break;
        case 3:
            s.Description = "Описание 4";
            break;
    }
    k = rnd.Next(4);
    switch (k)
    {
        case 0:
            s.Article = rnd.Next(1000, 9999);
            break;
        case 1:
            s.Article = rnd.Next(1000, 9999);
            break;
        case 2:
            s.Article = rnd.Next(1000, 9999);
            break;
        case 3:
            s.Article = rnd.Next(1000, 9999);
            break;
    }
    services[i] = s;
}


Good Good1 = new Good();
Good Good2 = new Good();

List<object> goods = new List<object> { Good1, Good2 };

for (int i = 0; i < 2; i++)
{
    Good g = new Good();
    int k = rnd.Next(4);
    switch (k)
    {
        case 0:
            g.Id = rnd.Next(10000, 99999);
            break;
        case 1:
            g.Id = rnd.Next(10000, 99999);
            break;
        case 2:
            g.Id = rnd.Next(10000, 99999);
            break;
        case 3:
            g.Id = rnd.Next(10000, 99999);
            break;
    }
    k = rnd.Next(4);
    switch (k)
    {
        case 0:
            g.Name = "Хлопок";
            break;
        case 1:
            g.Name = "Синтетика";
            break;
        case 2:
            g.Name = "Шелк";
            break;
        case 3:
            g.Name = "Шерсть";
            break;
    }
    k = rnd.Next(4);
    switch (k)
    {
        case 0:
            g.Description = "Описание 1";
            break;
        case 1:
            g.Description = "Описание 2";
            break;
        case 2:
            g.Description = "Описание 3";
            break;
        case 3:
            g.Description = "Описание 4";
            break;
    }
    k = rnd.Next(4);
    switch (k)
    {
        case 0:
            g.Article = rnd.Next(1000, 9999);
            break;
        case 1:
            g.Article = rnd.Next(1000, 9999);
            break;
        case 2:
            g.Article = rnd.Next(1000, 9999);
            break;
        case 3:
            g.Article = rnd.Next(1000, 9999);
            break;
    }
    goods[i] = g;

}
Console.WriteLine("======Услуги======");
reporting.Parse(services);
Console.WriteLine("");
Console.WriteLine("======Товары======");
reporting.Parse(goods);