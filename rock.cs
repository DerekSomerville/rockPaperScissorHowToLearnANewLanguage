using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			var weaponList = new List<string>() { "Rock", "Scissors","Paper"};
			Console.WriteLine("Please select 1. Rock, 2. Scissors or 3. Paper");
			int userWeapon = Convert.ToInt32(Console.ReadLine())-1;
			int computerWeapon;
			Random random = new Random();
			computerWeapon = random.Next(0,2);
			
			Console.WriteLine("Computer selected " + weaponList[computerWeapon]);
			Console.WriteLine("You selected " + weaponList[userWeapon]);
			
			if (userWeapon == computerWeapon)
			{ 
				Console.WriteLine("Draw both selected " + weaponList[computerWeapon]);
			} else if ((userWeapon+1)%3 == computerWeapon) {
			    Console.WriteLine("You win and beats the computer's " + weaponList[computerWeapon]);
			} else if ((computerWeapon+1)%3 == userWeapon) {
			    Console.WriteLine("Computer wins with " + weaponList[computerWeapon]);
			} else {
			    Console.WriteLine("Please select 1. Rock, 2. Scissors or 3. Paper");
			}
		}
	}
}
