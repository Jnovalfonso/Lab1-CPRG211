using System;

namespace CreatingClasses
{
    public class Program
    {
        static void Main()
        {
            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            gina.DisplayPersonInfo();
            Console.WriteLine(mike);
            ian.ChangeFavouriteColour();
            mary.GetAgeInTenYears();

            Relation ginaRelationMary = new Relation();
            ginaRelationMary.relationshipType = Relation.RelationshipType.Sister;
            ginaRelationMary.ShowRelationship (gina, mary);

            Relation ianRelationMike = new Relation();
            ianRelationMike.relationshipType = Relation.RelationshipType.Brother;
            ianRelationMike.ShowRelationship(ian, mike);

            List<Person> list = new List<Person>();
            list.Add(ian);
            list.Add(gina);
            list.Add(mike);
            list.Add(mary);
            
            List<Person> mInitial = new List<Person>();
            List<Person> blueFavourite = new List<Person>();

            float average = 0;
            Person minAge = list[0];
            Person maxAge = list[0];
            foreach (Person person in list)
            {
                average += person.age; 

                if (person.age < minAge.age)
                {
                    minAge = person;
                }

                else if (person.age > maxAge.age) 
                {
                    maxAge = person;
                }    

                if (person.firstName[0] == 'M')
                {
                    mInitial.Add(person);
                }

                if (person.favouriteColour == "Blue")
                {
                    blueFavourite.Add(person);
                }
            }

            Console.WriteLine($"The average age of the Person list is: {average / list.Count} \n");
            Console.WriteLine($"The minimum age '{minAge.age}' belongs to: {minAge.firstName}");
            Console.WriteLine($"The maximum age '{maxAge.age}' belongs to: {maxAge.firstName}");
            foreach (Person person in mInitial)
            {
                Console.WriteLine($"The person '{person.firstName}' has an M initial.");
                Console.WriteLine(person);
            }

            foreach (Person person in blueFavourite)
            {
                Console.WriteLine($"The color 'Blue' is {person.firstName}'s favourite.");
                Console.WriteLine(person);
            }
                      
        }
    }
}