import java.util.Scanner;
//import java.util.io.*;
import java.util.Random;

class RockPaperScissor {

	static void requestPlay(String[] weapons){
		String display = "Please select";
		/*for (int i=0;i<weapons.length;i++){*/
		int i=0;
		for (String weapon: weapons){
			i++;
			display += " " + i + ". " + weapon;
		};
		System.out.println(display);
	}
	
	public static void main(String[ ] args) {
		RockPaperScissor rockPaperScissor = new RockPaperScissor();
		rockPaperScissor.run();
	}
	public void run(){
		int userWeapon;
		/*BufferedReader userInput = 
		 new BufferedReader( new InputStreamReader(System.in));*/
		 
		Scanner userInput = new Scanner(System.in);
		Random rand = new Random();
		int computerWeapon;
		//Final declares a constant
		final String[] weaponList = {"Rock","Scissors","Paper"};
		//do{
			requestPlay(weaponList);
	  		userWeapon = userInput.nextInt()-1;
	  		computerWeapon = rand.nextInt(3);
			System.out.println("Users selected "+ weaponList[userWeapon] + " Computer selected " + weaponList[computerWeapon]);
			if (userWeapon == computerWeapon){
				System.out.println("Draw");
			} else if ((userWeapon + 1)%3 == computerWeapon){
				System.out.println("You won");
			} else if ((computerWeapon+1)%3 == userWeapon) {
				System.out.println("Computer won");
			}
		//} while (userWeapon< 4);
	}
}
