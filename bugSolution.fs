//Use immutable data structures as much as possible. 
let x = 10
let y = x
printfn "%d" x // Output: 10
//In this case, y does not point to x so changing y won't affect x
//If you need mutability, try to minimize its scope by using "let mutable" inside functions.
let modifyX (x:int) = 
    let mutable x = x
    x <- x+1
    x
let z = modifyX x
printfn "%d" x //Output:10
printfn "%d" z //Output:11