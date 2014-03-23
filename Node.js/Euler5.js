/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

function IsDivisibleByAll(val)
{
	for(var z = 1; z <= 20; z++)
	{
		if(val % z != 0) return false;
	}
	
	return true;
}

var curr = 20;

while (!IsDivisibleByAll(curr)) curr += 20;

console.log(curr);