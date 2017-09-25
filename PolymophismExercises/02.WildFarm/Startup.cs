using System;

namespace _02.WildFarm
{
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                var animalInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (animalInfo[0] == "End")
                {
                    break;
                }
                var foodInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                

                Animal animal = GetAnimal(animalInfo);
                Food food = GetFood(foodInfo);

                animal.Eat(food);
                animal.MakeSound();
            }
        }

        private static Food GetFood(string[] foodInfo)
        {
            var type = foodInfo[0];
            var quantity = int.Parse(foodInfo[1]);

            if (type == "Meat")
            {
                return new Meat(quantity);
            }
            return new Vegetable(quantity);
        }

        private static Animal GetAnimal(string[] animalInfo)
        {
            var animalType = animalInfo[0];

            switch (animalType)
            {
                case "Mouse":
                    return new Mouse(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3]);
                case "Cat":
                    return new Cat(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                case "Zebra":
                    return new Zebra(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3]);
                case "Tiger":
                    return new Tiger(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3]);
            }
            return null;
        }
    }
}
