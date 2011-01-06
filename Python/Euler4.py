def digits_gen():
	for x in range(100, 1000):
		for y in range(100,1000):
			s = str(x*y)
			if(s == s[::-1]):
				yield (x*y)

print max(digits_gen())