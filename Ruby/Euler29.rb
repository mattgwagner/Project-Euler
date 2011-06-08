#How many distinct terms are in the sequence generated by a^(b) 
#for 2 <= a  <= 100 and 2 <= b  <= 100?
require 'set'

s = Set.new

(2..100).each do|a|
	(2..100).each do|b|
		s.add a**b
	end
end

puts s.size