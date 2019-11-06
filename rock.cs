using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace SoloLearn
{
    class rock
    {
        static string generateRequest(String[] weapons)
        {
            String request = "Please select";
            int i = 0;
            foreach (string weapon in weapons)
            {
                i++;
                request += " " + i + ". " + weapon;
            }
            request += " 4. Exit";
            return request;
        }
        static int requestPlay(String[] weapons)
        {
            String request;
            request = generateRequest(weapons);
            Console.WriteLine(request);

            int userWeapon = Convert.ToInt32(Console.ReadLine()) - 1;

            return userWeapon;
        }
        static void displayWinner(string winner)
        {
            Console.WriteLine(winner);
        }
        static string determineWinner(String[] weaponList, int userWeapon, int computerWeapon)
        {
            String winner;
            if (userWeapon == computerWeapon)
            {
                winner = "Draw both selected " + weaponList[computerWeapon];
            }
            else if ((userWeapon + 1) % weaponList.Length == computerWeapon)
            {
                winner = "You win and beat the computer's " + weaponList[computerWeapon];
            }
            else if ((computerWeapon + 1) % weaponList.Length == userWeapon)
            {
                winner = "Computer wins with " + weaponList[computerWeapon];
            }
            else
            {
                winner = "Please select 1. Rock, 2. Scissors or 3. Paper";
            }

            return winner;

        }

        static void play(String[] weaponList)
        {
            int userWeapon;
            userWeapon = requestPlay(weaponList);
            while (userWeapon < weaponList.Length)
            {
                int computerWeapon;
                string winner;
                Random random = new Random();
                computerWeapon = random.Next(0, weaponList.Length -1);

                winner = determineWinner(weaponList, userWeapon, computerWeapon);
                displayWinner(winner);
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