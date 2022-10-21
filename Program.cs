using System.Text;
using ChallengeProjectHosting.Models;

Console.OutputEncoding = Encoding.UTF8;

// Create hosts templates and register in the hosts list
List<Person> hosts = new List<Person>();

Person p1 = new Person(name: "Host 1");
Person p2 = new Person(name: "Host 2");

hosts.Add(p1);
hosts.Add(p2);

try
{
    // Create the suite
    Suite suite = new Suite(typeSuite: "Premium", capacity: 2, dailyValue: 30);

    // Create a new booking, passing the suite and hosts
    Booking booking = new Booking(reservedDays: 10);
    booking.RegisterSuite(suite);
    booking.RegisterHosts(hosts);

    // Displays the number of hosts and the daily rate
    Console.WriteLine($"Hosts: {booking.GetQuantityHosts()}");
    Console.WriteLine($"Daily value: {booking.CalculateDailyValue()}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
    Console.ReadKey();