// See https://aka.ms/new-console-template for more information
using CollectionExample;

Console.WriteLine("Hello, World!");

List<Person> personCollection = new List<Person>();

personCollection.Add(new Person("Teppo", "Testi"));
personCollection.Add(new Person("Liisa", "Joki"));
personCollection.Add(new Person("Aino", "Virta"));
personCollection.Add(new Person("Matti", "Metsä"));
personCollection.Add(new Person("Matti", "Virta"));

Console.WriteLine("Listassa on "+ personCollection.Count + " henkilöä");
Console.WriteLine("Ensimmäisen etunimi="+personCollection[0].Fname);
Console.WriteLine("for-silmukalla nimet");
for(int x = 0;  x < personCollection.Count; x++)
{
    Console.WriteLine(personCollection[x].Fname+" " + personCollection[x].Lname);
}
Console.WriteLine("foreach silmukalla nimet");
foreach(Person onePerson in personCollection)
{
    Console.WriteLine(onePerson.Fname+ " "+onePerson.Lname);
}
var virtaCollection = from selected in personCollection
                          //where selected.Lname=="Virta"
                            where selected.Lname.Equals("Virta")
                    select selected;
Console.WriteLine();
Console.WriteLine("Virta nimiset");
foreach (var item in virtaCollection)
{
    Console.WriteLine(item.Fname + " " + item.Lname);
}