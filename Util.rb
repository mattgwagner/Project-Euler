require 'Set'

class Integer
	#check to see if the integer is prime
	def isPrime?	
		return true if self == 2
		return false if self % 2 == 0 or self < 2
		
		3.step(Math::sqrt(self), 2) do |i|
			return false if self % i == 0
		end
		
		true
	end
	
	#get the divisors of the integer
	def get_divisors
		s = Set.new
	
		(1..self*0.5).each do|c|
			s.add c if self % c == 0
		end
	
		s.add(self)
	end
	
	def calc_divisors
		res=[1]
		2.upto(Math.sqrt(self).floor) do |i|
			if self % i == 0
				res << i
			end
		end
		res.reverse.each do |i|
			res << self / i
		end
		res.uniq
	end
end

#borrowed from StackOverflow QuestionId:768821
def sieve_to(n)
	s = (0..n).to_a
	s[0]=s[1]=nil
	s.each do |p|
		next unless p
		break if p * p > n
		(p*p).step(n, p) { |m| s[m] = nil }
	end
	s.compact
end