
NAME : Yohannis hailye   ----------   1501575

                                  🚨 Emergency Response Simulation

       📜 Description
This C# console application simulates an Emergency Response System where players select appropriate emergency units to handle different incidents like Crime, Fire, Medical emergencies, and Rescue operations.

Players must choose the right unit based on the incident type to earn points. Wrong choices will cause a point deduction!

      🎯 Features
Abstract EmergencyUnit superclass with specialized subclasses:

Police: handles Crime

Firefighter: handles Fire

Ambulance: handles Medical

Helicopter: handles Rescue

Random incident generation with:

Type (Fire, Crime, Medical, Rescue)

Location

Difficulty (Easy, Medium, Hard)

Manual unit selection by the player.

Scoring system:

+10 points for correct unit

-5 points for incorrect unit

Final score displayed after 5 rounds.

         🏗️ Project Structure

   Class	                     Responsibility
EmergencyUnit	      Abstract base class for all emergency units.
Police	              Handles Crime incidents.
Firefighter	          Handles Fire incidents.
Ambulance	          Handles Medical incidents.
Helicopter	          Handles Rescue incidents (like airplane rescues).
Incident	          Represents an emergency incident with type, location, and difficulty.
Program	              Contains the Main method to run the simulation.

       🕹️ How to Play
Start the program.

Each turn, a random incident is generated.

Choose the correct unit from the list to respond.

Earn or lose points based on your choice.

After 5 rounds, your total score is displayed.

              📌 Notes => If you select the wrong unit, you lose points — think carefully!
