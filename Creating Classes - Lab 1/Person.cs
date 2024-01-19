using System;

namespace CreatingClasses 
{
    public class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favouriteColour;
        public int age;
        public bool isWorking;

        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string workingStatus = string.Empty;

            if (!isWorking)
            {
                workingStatus = "NOT";
            }
  
            string name = firstName + " " + lastName;
            Console.WriteLine($"{personId}. {name} is {age} years old, likes the {favouriteColour} colour and is {workingStatus} currently employed \n");
        }

        public void ChangeFavouriteColour()
        {
            favouriteColour = "White";
            Console.WriteLine($"{personId}. {firstName}'s Favourite Colour is now: {favouriteColour} \n");
        }
        
        public void GetAgeInTenYears()
        {
            Console.WriteLine($"{personId}. {firstName}'s age in ten years is: {age + 10} \n");
        }

        public override string ToString ()
        {
            return $"Personal Identifier: {personId} \n" +
                $"First Name: {firstName} \n" +
                $"Last Name: {lastName} \n" +
                $"Age: {age} \n" +
                $"Favourite Colour: {favouriteColour} \n" +
                $"Employment Status: {isWorking} \n";
        }
    }
}