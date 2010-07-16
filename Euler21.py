##Let d(n) be defined as the sum of proper divisors of n
##(numbers less than n which divide evenly into n).
##If d(a) = b and d(b) = a, where a != b, then a and b are an amicable
##pair and each of a and b are called amicable numbers.
##
##For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20,
##22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are
##1, 2, 4, 71 and 142; so d(284) = 220.
##
##Evaluate the sum of all the amicable numbers under 10000.
MAX = 10000

pairs = {}
s = 0

for curr in range(1,MAX):
    pairs[curr] = sum(i for i in range(1,curr) if curr % i == 0)

for k,v in pairs.items():
    if v in pairs and pairs[v] == k and k != v:
        print "Pair Found! %i & %i" % (k,v)
        s += k
        
print "Sum: %i" % (s)

