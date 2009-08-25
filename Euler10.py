##The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

##Find the sum of all the primes below two million.
from prime import isPrime

max = 2000000
sum = 1
for x in range(1,max,2):
    if isPrime(x):
        sum += x
print(sum)
