#Find the sum of all numbers, less than one million,
#which are palindromic in base 10 and base 2.
sum = 0

(1...1000000).each do|x|
	if x == x.to_s.reverse.to_i and x.to_s(2).to_i == x.to_s(2).reverse.to_i
		sum += x
	end
end

puts sum