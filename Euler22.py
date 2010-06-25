"""
Using names.txt, a 46K text file containing over five-thousand first names,
begin by sorting it into alphabetical order. Then working out the alphabetical
value for each name, multiply this value by its alphabetical position in the
list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN,
which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
So, COLIN would obtain a score of 938 x 53 = 49714.

What is the total of all the name scores in the file?
"""
import sys, os

vals = {}
names = []

letters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'

for l in letters:
    vals[l] = letters.index(l) + 1

#don't forget, lists are 0 indexed, so need to add 1
def score(name):
    return (names.index(name) + 1) * sum(vals[l] for l in name)


#read the file, split on commas, then remove quotation marks
with open(os.path.join(sys.path[0], "Euler22.txt")) as file:
    for name in file.read().split(','):
       names.append(name.replace("\"", ""))

names.sort()

print sum(score(name) for name in names)
