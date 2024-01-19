using System;

namespace CreatingClasses 
{
    public class Relation
    {
        public RelationshipType relationshipType; 
        public enum RelationshipType
        {
            Sister, Brother, Mother, Father
        }

        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"The relation between {person1.firstName} and {person2.firstName} is: {relationshipType}hood");
        }
    }
}