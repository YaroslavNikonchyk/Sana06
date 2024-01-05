using PeopleClasses;

People[] people = new People[4];
people[0] = new People("Yaroslav", "Nikonchuk", new DateTime(2006, 4, 19,16,30,00));
people[1] = new Applicant("David", "Paklin", new DateTime(2005, 9, 16, 18, 00, 00), 150, 10, "ZDSU");
people[2] = new Student("Bodan", "Bogdanovich", new DateTime(2004, 4, 25, 11, 20, 00), 1, 5, "IPZ", "ZDSU");
people[3] = new Teacher("Andiy", "Morozov", new DateTime(1990, 1, 1, 00, 00, 00), "rector", "IPZ", "ZDSU");

for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i].ShowInfo());
    Console.WriteLine();
}
