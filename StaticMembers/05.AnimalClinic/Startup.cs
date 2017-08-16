using System;

namespace _05.AnimalClinic
{
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                var info = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (info[0] == "End")
                {
                    break;
                }

                var animal=new Animal(info[0],info[1]);

                if (info[2] == "heal")
                {
                    AnimalClinic.HealAnimal(animal);
                    Console.WriteLine($"Patient {AnimalClinic.PatientId} [{animal.Name} ({animal.Breed})] has been healed!");
                }
                else if (info[2] == "rehabilitate")
                {
                    AnimalClinic.RehabilitateAnimal(animal);
                    Console.WriteLine($"Patient {AnimalClinic.PatientId} [{animal.Name} ({animal.Breed})] has been rehabilitated!");
                }
            }

            Console.WriteLine($"Total healed animals: {AnimalClinic.HealedAnimalsCount}\nTotal rehabilitated animals: {AnimalClinic.RehabilitedAnimalsCount}");

            var groupForPrint = Console.ReadLine();

            if (groupForPrint == "heal")
            {
                AnimalClinic.PrintAllHealedAnimals();
            }
            else
            {
                AnimalClinic.PrintAllRehabilitatedAnimals();
            }
        }
    }
}
