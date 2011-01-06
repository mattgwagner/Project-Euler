#2520 is the smallest number that can be divided by each
#of the numbers from 1 to 10 without any remainder.
#
#What is the smallest number that is evenly divisible by
#all of the numbers from 1 to 20?

current = 2520

while(not all(current % x == 0 for x in range(1,20))):
	current += 20
	
print current