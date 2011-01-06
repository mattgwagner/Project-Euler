#n! means n × (n  - 1) × ... × 3 × 2 × 1
#
#Find the sum of the digits in the number 100!
require 'Util'

sum = 0
100.factorial.to_s.each_byte{|x| sum += x.chr.to_i}
puts sum