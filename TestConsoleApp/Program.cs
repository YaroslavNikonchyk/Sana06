using PeopleClasses;

People[] people = new People[4];
people[0] = new People("Yaroslav", "Nikonchuk", new DateTime(2006, 4, 19));
people[1] = new Applicant("David", "Paklin", new DateTime(2005, 9, 16), 150, 10, "ZDSU");
people[2] = new Student("Bodan", "Bogdanovich", new DateTime(2004, 4, 25), 1, 5, "IPZ", "ZDSU");
people[3] = new Teacher("Andiy", "Morozov", new DateTime(1990, 1, 1), "rector", "IPZ", "ZDSU");

for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i].ShowInfo());
    Console.WriteLine();
}
