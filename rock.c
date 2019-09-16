#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void display_request();
char * append_char(char *str, char c);
void help();

const char *winner[3] = {"Rock","Scissors","Paper"};


int main() {
	int user_weapon;
	//get integer
	//do{
		display_request();
		/*get user input integer*/
		scanf("%i",&user_weapon);
		user_weapon --;
		int computer_weapon = rand() % 3;
		if(user_weapon == computer_weapon){
			printf("DRAW: You draw with %s\n",winner[user_weapon]);
	
		} else if ((user_weapon+1)%3 ==computer_weapon){
			printf("WIN: Your %s beats your %s\n",winner[user_weapon],winner[computer_weapon]);
		} else if ( (computer_weapon+1)%3 == user_weapon){
			printf("LOSE: The computer's %s beats your %s\n",winner[computer_weapon],winner[user_weapon]);
		} else if (user_weapon ==3){
			help();
		};
	//} while (user_weapon <4);
   
	return 0;
};

void help(){
	int i;
	for (i=0;i<3;i++){
		printf("%s beats %s\n",winner[i],winner[(i+1)%3]);
	};
	
	return 0;
}

char * append_char(char *str, char c){
	int len = strlen(str);
	
	str[len+1] = str[len];
	str[len] = c;
	
	return str;
};

void display_request(){
	int i;
	char c;
	char output[50];
	strcpy(output,"");
	for (i=0;i<3;i++){
		if(i>0){strcat(output,",");};
		strcat(output," ");
		c=(i+1)+'0';
		append_char(output,c);
		strcat(output,". ");
		strcat(output,winner[i]);
	};
	printf("Please select weapon%s, 4. help\n",output);
	
	return 0;
}
