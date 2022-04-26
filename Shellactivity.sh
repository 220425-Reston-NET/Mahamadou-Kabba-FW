#creating menu for a customer/user
repeat="true"

while [ "$repeat" == "true" ]
do
echo "Welcome to our grocery store!"
echo " 1 for beef"
echo " 2 for chicken"
echo " 3 for milk"
echo " 4 for eggs"
echo " 5 for jucie"
echo " done to checkout"
echo "enter 0 to exit"
read answer
if [ "$answer" == "0" ] 
then 
repeat="false"
     
elif [ "$answer" == "1" ]
then 
    echo " beef 3.99 dollars "
elif [ "$answer" == "2" ]
then 
   echo "chicken 4.99 dollars"
elif [ "$answer" == "3" ]
then
   echo "milk 5.99 dollar "
elif [ "$answer" == "4"  ]
then
   echo "eggs 6.99 dollars"
elif [ "$answer" == "5" ]
then
  echo "juice 7.99 dollars"
elif [ "$answer" == "done" ]
then
echo "thanks for shoping with us"
else
  echo "please pick a correct option"
fi
done
