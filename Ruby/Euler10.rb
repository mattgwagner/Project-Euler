#The sum of the primes below 10 is 2 + 3 + 25 + 7 = 17.
#
#Find the sum of all the primes below two million.
require 'Util'

puts (1..2000000).select{|x| x.isPrime?}.inject{|sum,c| sum+= c}