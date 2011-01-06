##By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13,
##we can see that the 6^(th) prime is 13.

##What is the 10001^(st) prime number?
from prime import isPrime

i = 0
curr = 0
while i < 10002:
    curr += 1
    if isPrime(curr):
        i += 1

print(curr)
