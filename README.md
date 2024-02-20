# Regular Expression - Check if divisible by 0b111 (7)
https://www.codewars.com/kata/56a73d2194505c29f600002d/csharp

DESCRIPTION:
Create a regular expression capable of evaluating binary strings (which consist of only 1's and 0's) and determining whether the given string represents a number divisible by 7.

Note:

Empty strings should be rejected.
Your solution should reject strings with any character other than 0 and 1.
No leading 0's will be tested unless the string exactly denotes 0.

For this project I got to deep dive into converting Finite State Machines into Regex. I relied heavily on Ivan Zuzak and Vedrana Jankovic's online tools to build and test the FSM. https://ivanzuzak.info/noam/webapps/fsm_simulator/
