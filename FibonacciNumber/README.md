Fibonacci number calculation using bruteforce method and dynamic programming

The Fibonacci numbers are the numbers in the following integer sequence.

0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ……..

In mathematical terms, the sequence Fn of Fibonacci numbers is defined by the recurrence relation

    Fn = Fn-1 + Fn-2
with seed values

   F0 = 0 and F1 = 1.
   
                         fib(5)   
                     /                  
               fib(4)                fib(3)   
             /                      /     
         fib(3)      fib(2)         fib(2)    fib(1)
        /             /           /      
  fib(2)   fib(1)  fib(1) fib(0) fib(1) fib(0)
  /    
fib(1) fib(0)

   
Here using dynamic programming we will avoid repeated calculations.
