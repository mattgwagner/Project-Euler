#Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
file = File.new("Euler13.txt", "r")
sum = 0

while(line = file.gets)
	sum += line.to_i
end

puts sum.to_s()[0...10]