#What is the value of the first triangle number to have over five hundred divisors?
require 'Util'

past = 1

(1..500000).each do|x|
	if past.calc_divisors.size > 500
		puts x
		break
	end
	
	past +=x
end

#NOT FINISHED