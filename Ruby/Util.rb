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
	
		(1..Math::sqrt(self)).each do|c|
			if self % c == 0
				s.add c
				s.add (self / c)
			end
		end
	
		s.add(self)
	end
	
	def factorial
		if self == 0
			1
		else
			self * (self-1).factorial
		end
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