##2520 is the smallest number that can be divided by each
##of the numbers from 1 to 10 without any remainder.
##
##What is the smallest number that is evenly divisible by
##all of the numbers from 1 to 20?
for x in range(20,300000000,20):
    all = True
    for y in range(1,20):
        if x % y != 0:
            all = False
            break
    if all:
        print(x)
        break
