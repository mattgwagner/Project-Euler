class Integer
	def isPrime?
		if self == 1 or self == 2
			return true
		end
		
		if self % 2 == 0
			return false
		end
		
		3.step(Math::sqrt(self), 2) do |i|
			if self % i == 0
				return false
			end
		end
		
		true
	end
end