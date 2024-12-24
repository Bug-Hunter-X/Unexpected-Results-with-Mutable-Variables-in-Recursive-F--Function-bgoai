let mutable x = 0
let mutable y = 1
let mutable z = 0

let rec loop i =
    if i > 100 then
        ()
    else
        let temp = x + y
        x <- y
        y <- temp
        z <- z + 1
        loop (i + 1)

loop 0
printf "%d %d %d" x y z