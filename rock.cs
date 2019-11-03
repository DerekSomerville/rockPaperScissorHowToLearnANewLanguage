using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace SoloLearn
{
    class Program
    {
        static int requestPlay(String[] weapons)
        {
            String display = "Please select";
            int i = 0;
            foreach (string weapon in weapons)
            {
                i++;
                display += " " + i + ". " + weapon;
            }
            Console.WriteLine(display);

            int userWeapon = Convert.ToInt32(Console.ReadLine()) - 1;

            return userWeapon;
        }

        static void determineWinner(String[] weaponList, int userWeapon, int computerWeapon)
        {
            if (userWeapon == computerWeapon)
            {
                Console.WriteLine("Draw both selected " + weaponList[computerWeapon]);
            }
            else if ((userWeapon + 1) % weaponList.Length == computerWeapon)
            {
                Console.WriteLine("You win and beats the computer's " + weaponList[computerWeapon]);
            }
            else if ((computerWeapon + 1) % weaponList.Length == userWeapon)
            {
                Console.WriteLine("Computer wins with " + weaponList[computerWeapon]);
            }
            else
            {
                Console.WriteLine("Please select 1. Rock, 2. Scissors or 3. Paper");
            }

        }

        static void play(String[] weaponList)
        {
            int userWeapon;
            userWeapon = requestPlay(weaponList);
            while (userWeapon < weaponList.Length)
            {
                int computerWeapon;
                Random random = new Random();
                computerWeapon = random.Next(0, weaponList.Length -1);

                Console.WriteLine("Computer selected " + weaponList[computerWeapon]);
                Console.WriteLine("You selected " + weaponList[userWeapon]);

                determineWinner(weaponList, userWeapon, computerWeapon);
                userWeapon = requestPlay(weaponList);
            }
        }

        static void Main(string[] args)
        {
            var weaponList = new String[] { "Rock", "Scissors", "Paper" };
            play(weaponList);
        }
    }
}