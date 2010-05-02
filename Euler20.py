#Find the sum of the digits in the number 100!
def factorial(i):
    if i == 0:
        return 1
    else:
        return i * factorial(i-1)

print sum(int(x) for x in str(factorial(100)))