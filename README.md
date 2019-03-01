# kata-roman-numeral-addition
A TDD exercise

## Goal
Use test driven development to write a library that can add roman numerals. Practice writing tests first, and using your test failures to guide the code you write. For the sake of this exercise, do not convert the numerals to arabic numbers.

A dotnet standard library and a test project have been started for you, including your first failing test!

## Description
The Romans wrote their numbers using letters; specifically the letters "I, V, X, L, C, D, and M." There were certain rules that the numerals followed which should be observed.

* The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row. 'V', 'L', and 'D' can never be repeated.
* As arabic numbers can be split into their constituent parts (1066 becomes 1 0 6 6), so too can Roman numerals, just without the zero (1066 becomes MLXVI, or M (1000) LX (60) and VI (6)).
* When lower value numerals come before higher value numerals, it signals subtraction.
* The symbols ('I', 'X', and 'C') can only be subtracted from the 2 next highest values ('IV' and 'IX', 'XL' and 'XC', 'CD' and 'CM'). 
* The symbols ('V', 'L', and 'D') can never be subtracted.
* Only one subtraction can be made per numeral ('XC' is allowed, 'XXC' is not).

## Credits
I did not write this kata, and I don't know who did. Whoever you are, thanks! I hope you don't mind that I polished it up a bit.  
