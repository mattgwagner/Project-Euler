##The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

##Find the sum of all the primes below two million.
from prime import isPrime

print sum(x for x in range(1,2000000,2) if isPrime(x))
