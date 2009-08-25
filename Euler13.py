#Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
file = open('Euler13.txt')
sum = 0

for l in file.readlines():
    sum += int(l)
print(str(sum)[:10])
