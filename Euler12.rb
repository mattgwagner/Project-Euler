#What is the value of the first triangle number to have over five hundred divisors?
require 'Util'

def get_triangle_sum(i)
	return (1..i).inject{|sum,x| sum + x}
end

curr = 1

while get_triangle_sum(curr).get_divisors.size < 500
	curr += 1
end

puts get_triangle_sum(curr)