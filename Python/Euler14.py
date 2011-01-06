##The following iterative sequence is defined for the set of positive integers:
##
##n -> n/2 (n is even)
##n -> 3n + 1 (n is odd)
##
##Using the rule above and starting with 13, we generate the following sequence:
##13 ->40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
##
##It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
##
##Which starting number, under one million, produces the longest chain?
dict = {}
length = 0
largest = 0

#utilizes a dictionary to store pre-computed chain lengths
def count(x):
	key = x
	cnt = 0
	while x != 1:
		if x not in dict:
			cnt += 1
			if x % 2 == 0:
				x = x/2
			else:
				x = 3*x + 1
		else:
			cnt += dict[x]
			break
	dict[key] = cnt
	return dict[key]

for x in range(1,1000000):
	p = count(x)
	if p > length:
		length = p
		largest = x
		
print largest