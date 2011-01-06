##Each new term in the Fibonacci sequence is generated by
##adding the previous two terms. By starting with 1 and 2,
##the first 10 terms will be:
##
##1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
##
##Find the sum of all the even-valued terms in the sequence
##which do not exceed four million.

def fib_generator():
	a, b = 1, 2
	yield 1
	while b < 4000000:
		yield b
		a, b = b, a+b

print sum(x for x in fib_generator() if x % 2 == 0)