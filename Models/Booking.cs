namespace ChallengeProjectHosting.Models
{
    public class Booking
    {
        public List<Person> Hosts { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Booking() { }

        public Booking(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterHosts(List<Person> hosts)
        {
            if (Suite.Capacity >= hosts.Count())
            {
                Hosts = hosts;
            }
            else
            {
                throw new Exception("The number of hosts exceeds the capacity of the Suite."); 
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetQuantityHosts()
        {

            return Hosts.Count;
        }

        public decimal CalculateDailyValue()
        {

            decimal value = ReservedDays * Suite.ValueDiaria;
            if (ReservedDays >= 10)
            {
                value -= (value * 10 / 100);
            }

            return value;
        }
    }
}