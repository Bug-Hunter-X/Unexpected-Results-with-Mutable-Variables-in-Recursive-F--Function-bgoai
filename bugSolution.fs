let rec fibonacci i =
    match i with
    | 0 -> 0
    | 1 -> 1
    | _ -> fibonacci (i - 1) + fibonacci (i - 2)

let x = fibonacci 10
let y = fibonacci 11
let z = 12 // This is now correct and deterministic
printf "%d %d %d" x y z