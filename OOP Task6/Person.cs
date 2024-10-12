namespace OOP_Task6
{
    internal class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
            public Person(string name,string surname,int age)
            {
             Name = name;
             Surname = surname;
             Age = age;
            }
            public static bool operator >(Person a, Person b) 
        {
            return a.Age > b.Age;
        }
        public static bool operator <(Person a, Person b) 
        { 
            return a.Age < b.Age; 
        }

        public int CompareTo(object? obj)
        {
            if (obj == null || obj is not Person)
                return -1;
            Person person = obj as Person;
            return Age.CompareTo(person.Age);
        }
    }
}
