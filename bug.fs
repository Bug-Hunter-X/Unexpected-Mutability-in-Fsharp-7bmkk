let mutable x = 10
let y = &x
!y <- 20
printfn "%d" x // Output: 20

//In this example, we are using mutable variables and references. This can lead to unexpected behavior if not handled properly. 
//For example, if another part of your code modifies the value of x, it will also affect the value of y.  This is not always obvious and can be a source of unexpected behavior and bugs.