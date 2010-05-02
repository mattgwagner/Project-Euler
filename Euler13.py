#Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
file = open('Euler13.txt')

print str(sum(int(l) for l in file.readlines()))[:10]

