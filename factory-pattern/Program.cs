

factory_pattern.Car hydroCar= new factory_pattern.HydrogenCar();

factory_pattern.Car electricCar = new factory_pattern.ElectricCar();

hydroCar.start();
electricCar.start();

factory_pattern.ItemFactory randomItem = new factory_pattern.RandomItem();
factory_pattern.ItemFactory hammer = new factory_pattern.SpecificItem(0);
factory_pattern.ItemFactory shield = new factory_pattern.SpecificItem(1);

Console.WriteLine("Drop some random items!");
Console.WriteLine();
randomItem.DropItem().UseItem();
randomItem.DropItem().UseItem();
randomItem.DropItem().UseItem();
randomItem.DropItem().UseItem();
randomItem.DropItem().UseItem();
randomItem.DropItem().UseItem();
Console.WriteLine();
Console.WriteLine($"HAMMER DROPPED...");
hammer.DropItem().UseItem();
Console.WriteLine("Shield DROPPED...");
shield.DropItem().UseItem();






