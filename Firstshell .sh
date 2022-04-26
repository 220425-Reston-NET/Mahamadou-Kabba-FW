#setting a variable 
msg = "hello world"
echo $msg
#control flow 
#telling the program to run multiple lines of code muliple times
#we can tell the program to run lines od code if a condition is met
#if statement
ten=10
five=5
thirteen=13
echo "===First If==="
if [ "$ten" -ge "$five" ]
then 
echo "greater!"
echo "$ten > $five"
fi
