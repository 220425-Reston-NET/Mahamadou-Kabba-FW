#this is a comment
#it's like putting sticky notes to give little more meaning full message
# of what you're doing in this scripting
# "echo" is a way to give a feedback to the person runing this shell  scripting
echo " this is going to be my first script"

# Variables
msg="Hello World Variable"
echo $msg # $ Syntax is what need to write to specify that we are referencing a variable

# Control Flow
# They are a way to tell the program to run multiple lines of code multiple times or
# We can tell the program to run lines of code if a condition is met

# If Statements
ten=10
five=5
thirteen=13

echo "===First If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$ten > $five"
fi

echo "This is outside of the then fi"

echo "===Second If==="

if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then
echo "Lesser!"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -ge "$thirteen" ]
then
echo "Greater!"
echo "$five > $thirteen"
else
echo "Nothing Matches"
fi

# Loops Statement
# A way to repeat multiple lines of code x amount of times you want

# For Loops statment
# Will repeat x amount of times
# Useful if you nkow how many times you need to execute those lines of code

echo "===For Loops==="
echo "===First Loop==="
for number in 10 5 World 1 2
do
echo "Hello $number"
echo "World"
echo "Testing"
echo "Line 4"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

echo "===While Loops==="
# While Loop statement
# Will repeat your lines of code multiple times as long as the condition is true
# Useful if you don't know how many times you need to execute those lines of code

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) # $((mathematical operation)) syntax is how we can do math stuff
echo "$five"
done

# Input and Output
# We can ask for inputer from the user that is using the shell scripting and output some sort of response
echo "What is your name?"
#read name # Read [wahtever variable name you specify] will store the user input in that variable

echo "Hello $name, Welcome to programming!"

# Making a shell menu
clear #clesr cleans terminal
repeat="true"
while [ "$repeat" == "true" ]
do 
echo "welcome to shell scripting"
echo "what do you to do today"
echo "enter 1 for adding two number?"
read answer 
if  [ "$answer" == "1"  ]
then
   echo "Give me number 1"
   read num1
   echo "Give me number 2"
   read num2
   echo "the sum is $(($num1+num2))"
elif [ "$answer" == "2" ]
then
 repeat="false"
else  
echo "please enter a correct option"
fi
done
