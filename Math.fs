﻿module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let isEven n = n % 2UL = 0UL

let f n =
  if isEven n then n/2UL
  else 3UL * n + 1UL

let collatz n =
  let rec iter n count = 
    let result = f n
    if result = 1UL then count
    else iter result count+1
  iter (uint64 n) 1


// 