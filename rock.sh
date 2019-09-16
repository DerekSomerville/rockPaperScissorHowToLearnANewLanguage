if [ $# -ne 1 ]
  then echo "rock.sh 0. Rock, 1. Scissors 2. Paper e.g. rock.sh 1"
  exit 0
fi
user_weapon=$1
computer_weapon=`jot -r 1 0 2`
function weapon() {
  case $1 in 
    0)
      name="Rock";;
    1)
      name="Scissors";;
    2)
      name="Paper";;
  esac
  echo $name
}
echo "User selected: "
weapon $user_weapon
echo "Computer selected: " 
weapon $computer_weapon
case $user_weapon in
  $computer_weapon)
     echo "Draw";;
  $(((computer_weapon -1)%3)))
     echo "You won";;
  $(((computer_weapon + 1)%3)))
     echo "Computer won";;
  *)
     echo "No match";;
esac

