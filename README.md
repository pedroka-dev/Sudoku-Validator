# Sudoku-Validator
A console application that says if string is a valid Sudoku

# What is a Sudoku?

The Sudoku grid is a 9x9 matrix of integers. For it to be a valid solution, each row and column must contain all numbers from 1 to 9. 
Additionally, if we divide the matrix into nine 3x3 regions, each of these regions must also contain the numbers from 1 to 9. 
The example below shows a grid that is a valid Sudoku solution.

# Example

The input consists of several matrices. Each matrix is given in 9 lines, where each line contains 9 integers. Your program should print "SIM" if the matrix is a valid Sudoku solution, and "NAO" otherwise.
Input:
4 9 8 2 6 1 3 7 5

7 5 6 3 8 4 2 1 9

6 4 3 1 5 8 7 9 2

5 2 1 7 9 3 8 4 6

9 8 7 4 2 6 5 3 1

2 1 4 9 3 5 6 8 7

3 6 5 8 1 7 9 2 4

8 7 9 6 4 2 1 5 3

 

Output:
SIM
