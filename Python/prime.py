import math

dict = {2:True,3:True,4:False}

def isPrime(n):
    if n not in dict:
        dict[n] = n % 2 != 0
        if dict[n]:
            i = 2
            while i <= math.sqrt(n):
                if n % i == 0:
                    dict[n] = False
                i += 1
    return dict[n]

