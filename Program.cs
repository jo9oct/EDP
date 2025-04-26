// See https://aka.ms/new-console-template for more information
using System;

namespace EmergencyResponse
{
    // EmergencyUnit unit Super Class
    public abstract class EmergencyUnit
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public EmergencyUnit(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        // Abstract methods to handle incidents
        public abstract bool CanHandle(string incidentType);
        public abstract void RespondToIncident(Incident incident);
    }

    // Police unit Sub Class
    public class Police : EmergencyUnit
    {
        public Police() : base("Police", 50) { }

        public override bool CanHandle(string incidentType)
        {
            return incidentType == "Crime";
        }

        public override void RespondToIncident(Incident incident)
        {
            Random random = new Random();
            string unit = "Unit " + random.Next(1, 10);
            Console.WriteLine($"{Name} {unit} is responding to a {incident.Type} at {incident.Location}. Speed: {Speed} km/h");
        }
    }

    // Firefighter unit Sub Class
    public class Firefighter : EmergencyUnit
    {
        public Firefighter() : base("Firefighter", 60) { }

        public override bool CanHandle(string incidentType)
        {
            return incidentType == "Fire";
        }

        public override void RespondToIncident(Incident incident)
        {  
            Random random = new Random();
            string unit = "Unit " + random.Next(1, 10);
            Console.WriteLine($"{Name} {unit} is responding to a {incident.Type} at {incident.Location}. Speed: {Speed} km/h");
        }
    }

    // Ambulance unit Sub Class
    public class Ambulance : EmergencyUnit
    {
        public Ambulance() : base("Ambulance", 70) { }

        public override bool CanHandle(string incidentType)
        {
            return incidentType == "Medical";
        }

        public override void RespondToIncident(Incident incident)
        {  
            Random random = new Random();
            string unit = "Unit " + random.Next(1, 10);
            Console.WriteLine($"{Name} {unit} is responding to a {incident.Type} at {incident.Location}. Speed: {Speed} km/h");
        }
    }

    // Helicopter unit Sub Class
    public class Helicopter : EmergencyUnit
    {
        public Helicopter() : base("Helicopter", 90) { }

        public override bool CanHandle(string incidentType)
        {
            return incidentType == "Rescue";
        }

        public override void RespondToIncident(Incident incident)
        {
            Random random = new Random();
            string unit = "Unit " + random.Next(1, 10);
            Console.WriteLine($"{Name} {unit} is responding to a {incident.Type} at {incident.Location}. Speed: {Speed} km/h");
        }
    }

    public class Incident
    {
        public string Type { get; set; }
        public string Location { get; set; }
        public string Difficulty { get; set; }

        public Incident(string type, string location, string difficulty)
        {
            Type = type;
            Location = location;
            Difficulty = difficulty;
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of emergency units
            EmergencyUnit police = new Police();
            EmergencyUnit firefighter = new Firefighter();
            EmergencyUnit ambulance = new Ambulance();
            EmergencyUnit helicopter = new Helicopter();

            // List of emergency units
            EmergencyUnit[] units = { police, firefighter, ambulance, helicopter};

            int score = 0;
            Random random = new Random();

            // Run for 5 rounds
            for (int turn = 1; turn <= 5; turn++)
            {
                Console.WriteLine($"\n--Turn-- {turn}");

                string[] incidentTypes = { "Fire", "Crime", "Medical", "Rescue" };
                string[] Difficulty = { "Easy","Mediam","Hard" };

                string incidentType = incidentTypes[random.Next(incidentTypes.Length)];
                string location = "Location " + random.Next(1, 10);
                string difficulty =Difficulty[random.Next(Difficulty.Length)];  // Difficulty 1 to 3

                Incident incident = new Incident(incidentType, location, difficulty);
                Console.WriteLine($"Incident: {incident.Type} at {incident.Location} (Difficulty: {incident.Difficulty})");

                Console.WriteLine("\nSelect a unit to respond:");
                for (int i = 0; i < units.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {units[i].Name}");
                }
                int unitChoice = int.Parse(Console.ReadLine()) - 1;

                EmergencyUnit selectedUnit = units[unitChoice];

                // Check if the unit can handle the incident
                if (selectedUnit.CanHandle(incident.Type))
                {
                    selectedUnit.RespondToIncident(incident);
                    score += 10;   // gain score per 1 try
                    Console.WriteLine("+10 Points");
                }
                else
                {
                    Console.WriteLine("This unit cannot handle the incident.");
                    score -= 5;   // lose score per 1 try
                    Console.WriteLine("-5 Points");
                }

                // Display the current score after each round
                Console.WriteLine($"Current Score: {score}");
            }

            // Display final score after 5 rounds
            Console.WriteLine($"\nFinal Score: {score}");
        }
    }
}
