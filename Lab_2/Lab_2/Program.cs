using Lab_2.task_1.subscriptions;
using Lab_2.task_1.subscriptionsCreators;
using Lab_2.task_2.factories;
using Lab_2.task_2.products;
using Lab_2.task_3;
using Lab_2.task_4;
using Lab_2.task_5.Builders;
using Lab_2.task_5.Characters;


// Оскільки завдання було виконанно в мінімальному вигляді, деякі рішення (такі як використання різних інтерфейсів для ноутбуків та телефонів, хоча на даний момент ці інтерфейси ідентичні)
// здаються недоцільними, але вони б знадобились для подальшого розвитку програми.


Console.WriteLine("Виберіть завдання(1-5): ");
switch (Console.ReadLine())
// Щоб не вибирати кожен раз завдання)
// string task = "5";
// switch(task) 
{
    case "1":
        WebSiteSubscriptionCreator web= new WebSiteSubscriptionCreator();
        ISubscription webSubscription = web.CreateSubscription(SubscriptionType.DomesticSubscription, 16);
        webSubscription.Info();
        Console.WriteLine();

        MobileAppSubscriptionCreator mobile = new MobileAppSubscriptionCreator();
        ISubscription mobileSubscription = mobile.CreateSubscription(SubscriptionType.EducationalSubscription, 12);
        mobileSubscription.Info();
        Console.WriteLine();

        ManagerCallSubscriptionCreator callSubscriptionCreator = new ManagerCallSubscriptionCreator();
        ISubscription callSubscription = callSubscriptionCreator.CreateSubscription(SubscriptionType.PremiumSubscription, 1);
        callSubscription.Info();
        Console.WriteLine();
        break;
    case "2":
        IFactory kiaomiFactory = new KiaomiFactory();
        IProductLaptop kiaomiLaptop = kiaomiFactory.CreateProductLaptop("KiaomiLaptop");
        IProductSmartphone kiaomiSmartphone = kiaomiFactory.CreateProductSmartphone("KiaomiSmartphone");
        kiaomiLaptop.Info();
        Console.WriteLine();
        kiaomiSmartphone.Info();
        Console.WriteLine();
        
        IFactory pearFactory = new PearFactory();
        IProductLaptop pearLaptop = pearFactory.CreateProductLaptop("Mocbook");
        IProductSmartphone pearSmartphone = pearFactory.CreateProductSmartphone("EPhone");
        pearLaptop.Info();
        Console.WriteLine();
        pearSmartphone.Info();
        Console.WriteLine();
        break;
    case "3":
        for (int i = 0; i < 10; i++) 
        { 
            var t = new Thread(() => Authenticator.GetInstance());
            t.Start(); 
        }
        break;
    case "4":
        Virus firstVirus = new Virus("firstVirus", 100, 5, "Type A", []);
        Virus secondVirus1 = new Virus("secondVirus1", 80, 3, "Type B", []);
        Virus secondVirus2 = new Virus("secondVirus2", 90, 4, "Type C", []);
        firstVirus.Children.Add(secondVirus1);
        firstVirus.Children.Add(secondVirus2);

        Virus thirdVirus1 = new Virus("thirdVirus1", 60, 1, "Type D", []);
        Virus thirdVirus2 = new Virus("thirdVirus2", 70, 2, "Type E", []);
        secondVirus1.Children.Add(thirdVirus1);
        secondVirus2.Children.Add(thirdVirus2);

        Virus clonedFirst = (Virus) firstVirus.Clone();

        Console.WriteLine("Original firstVirus:");
        Console.WriteLine(firstVirus);
        Console.WriteLine("Cloned firstVirus:");
        Console.WriteLine(clonedFirst);
        break;
    case "5":
        Character hero = HeroBuilder.Create().ClassIs("Mage").HeightIs(180).PhysiqueIs("Athletic").HairColorIs("Red").EyeColorIs("Blue").ClothesAre("Newbie clothes").InventoryIs(["Magic Wand","Magic potion"]).SetSpecial("FIREBALL!!!").CreateCharacter();
        Character enemy = EnemyBuilder.Create().ClassIs("Vampire").HeightIs(190).PhysiqueIs("Athletic").HairColorIs("White").EyeColorIs("Red").ClothesAre("Aristocratic clothes").InventoryIs(["Sword"]).SetSpecial("metamorphosis").CreateCharacter();
        Console.WriteLine(hero);
        Console.WriteLine(enemy);
        break;
    default:
        throw new NotImplementedException("Виберіть число від 1 до 5");
        
        
}
