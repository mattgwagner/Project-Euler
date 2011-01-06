#What is the first term in the Fibonacci sequence to contain 1000 digits?

def fib_gen():
    a, b = 1, 1
    yield a
    while True:
        yield b
        a,b = b, a+b
i = 1

for x in fib_gen():
    if(len(str(x)) == 1000):
        print i
        break
    i += 1
    
