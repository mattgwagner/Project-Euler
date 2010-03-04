class Integer
	def isPrime?	
		return true if self == 2
		return false if self % 2 == 0 or self < 2
		
		3.step(Math::sqrt(self), 2) do |i|
			return false if self % i == 0
		end
		
		return true
	end
end