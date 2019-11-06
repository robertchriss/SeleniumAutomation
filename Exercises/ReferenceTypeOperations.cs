namespace Exercises
{
    public static class ReferenceTypeOperations
    {
        public static int ReturnPerson2Age(PersonModel person1, int newPerson1Age)
        {
            PersonModel person2 = new PersonModel();
            person2 = person1;
            //person1.age = newPerson1Age;

            return person2.age;
        }
    }
}
