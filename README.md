# F# Mutable Variable Recursion Bug

This repository demonstrates a potential issue with mutable variables in recursive functions within F#. The `bug.fs` file contains code that exhibits unexpected behavior due to the interaction between mutable variables and recursion. The `bugSolution.fs` file provides a corrected version that avoids the problem.

## Problem Description
The original code calculates Fibonacci numbers using mutable variables. However, due to the nature of mutable state and recursive function calls, the outcome is incorrect.

## Solution
The corrected code uses immutable variables and functional programming concepts. This eliminates the mutable state issues and produces the correct results.

## How to Run
1. Clone this repository.
2. Open the `bug.fs` and `bugSolution.fs` files in a F# development environment.
3. Run each file to observe the different outputs.