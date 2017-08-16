using System;
using System.Collections.Generic;

namespace _05.AnimalClinic
{
    public class AnimalClinic
    {
        private static int patientId;
        private static int healedAnimalsCount;
        private static int rehabilitedAnimalsCount;
        private static List<Animal> healedAnimalsList=new List<Animal>();
        private static List<Animal> rehabilitatedAnimalsList=new List<Animal>();

        public static List<Animal> HealedAnimalsList
        {
            get { return AnimalClinic.healedAnimalsList; }
        }

        public static List<Animal> RehabilitatedAnimalsList
        {
            get { return AnimalClinic.rehabilitatedAnimalsList; }
        }

        public static int PatientId
        {
            get { return AnimalClinic.patientId; }
            set { AnimalClinic.patientId = value; }
        }

        public static int HealedAnimalsCount
        {
            get { return AnimalClinic.healedAnimalsCount; }
            set { AnimalClinic.healedAnimalsCount = value; }
        }

        public static int RehabilitedAnimalsCount
        {
            get { return AnimalClinic.rehabilitedAnimalsCount; }
            set { AnimalClinic.rehabilitedAnimalsCount = value; }
        }

        public static void HealAnimal(Animal animal)
        {
            AnimalClinic.patientId++;
            AnimalClinic.healedAnimalsCount++;
            healedAnimalsList.Add(animal);
        }

        public static void RehabilitateAnimal(Animal animal)
        {
            AnimalClinic.patientId++;
            AnimalClinic.rehabilitedAnimalsCount++;
            rehabilitatedAnimalsList.Add(animal);
        }

        public static void PrintAllHealedAnimals()
        {
            foreach (var animal in AnimalClinic.HealedAnimalsList)
            {
                Console.WriteLine($"{animal.Name} {animal.Breed}");
            }
        }

        public static void PrintAllRehabilitatedAnimals()
        {
            foreach (var animal in AnimalClinic.RehabilitatedAnimalsList)
            {
                Console.WriteLine($"{animal.Name} {animal.Breed}");
            }
        }
    }
}
