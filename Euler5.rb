#2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
#
#What is the smallest number that is evenly divisible by all of the numbers from 1 to 20?
current = 2520

def check? x
	for y in (1...20)
		if x % y != 0
			return false
		end
	end
	
	return true
end

while !check? current
	current += 20
end

puts current