##A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
##a^(2) + b^(2) = c^(2)
##
##For example, 3^(2) + 4^(2) = 9 + 16 = 25 = 5^(2).
##
##There exists exactly one Pythagorean triplet for which a + b + c = 1000.
##Find the product abc.
import math

def check(a,b,c):
    return (a**2 + b**2 == c**2) and (a < b < c) and (a + b + c == 1000)

for a in range(1,1000):
    for b in range(a+1,1000):
        c = math.sqrt(a**2 + b**2)
        if check(a,b,c):
            print (a * b * c)
