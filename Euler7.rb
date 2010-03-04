#By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
#we can see that the 6^(th) prime is 13.
#
#What is the 10001^(st) prime number?

require 'Util'

curr = 3
count = 2

count += 1 if (curr += 2).isPrime? until count == 10001

print curr