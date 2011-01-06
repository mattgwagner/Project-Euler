=begin
Using names.txt, a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 x 53 = 49714.

What is the total of all the name scores in the file?

ANSWER: 871198282
=end
require 'jcode'
$letters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
$names = Array.new

def score name
	sum = 0
	
	name.each_char do|c|
		sum += ($letters.index(c) + 1)
	end
	
	return sum * ($names.index(name) + 1)
end

File.open("Euler22.txt", "r").read.split(',').each do|n|	
	$names.push n.gsub("\"", "")
end

$names.sort!

sum = 0

$names.each do |name|
	sum += score(name)
end

print sum