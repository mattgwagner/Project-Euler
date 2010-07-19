#How many, not necessarily distinct, values of
#nCr, for 1 <= n  <= 100, are greater than one-million?

def factorial(i):
    if i == 0:
        return 1
    else:
        return i * factorial(i-1)

#generates a list of the same length as the # of selections with > 1000000 choices
def get_combinations(n):
    for r in range(1,n+1):
        if factorial(n)/(factorial(r)*factorial(n-r)) > 1000000:
            yield 1  

print sum(len(list(get_combinations(n))) for n in range(1,101))
