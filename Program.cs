using System.Net.NetworkInformation;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args) {
            System.Console.WriteLine("It worked");
        }

        static Program() {
            new PhysicalAddress(null);
        }
    }
}
