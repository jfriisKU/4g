(* Opgave 4g.1
 *
 * Gruppe 10:
 *  Jonas Friis
 *  Claes Heise
 *  Morten Risum Pedersen
 *)

/// Vi bør ikke skrive kommandoerne igen,
/// men referere til dem gennem biblioteket vec2d.fs.

let len ((x,y): (float * float)) : float =
    ((x*x)+(y*y))**(1.0/2.0)

let ang ((x,y): (float * float)) : float =
    (atan2 y x)

let scale ((x,y): (float * float)) (a:float) : (float * float) =
    ((x*a),(y*a))

let dot ((x1,y1): (float * float)) ((x2,y2): (float * float)) : (float * float) =
    ((x1*x2),(y1*y2))

let add ((x1, y1) : (float * float)) ((x2, y2) : (float * float)) : (float * float) =
    (x1+x2, y1+y2)

printfn "White-box testing of vec2d.fs"
printfn " Unit : len"
printfn "   Branch : 0 - %b " (len (0.0, 100.0) = 100.0000)
printfn " Unit : ang"
printfn "   Branch : 0 - %b " (System.Math.Round (ang (10.0, 5.0), 6) = 0.463648)
printfn " Unit : scale"
printfn "   Branch : 0 - %A " ((scale (4.0, 6.0) 5.0) = (20.0, 30.0))
/// The dot function needs to be re-tested as per the library change.
printfn " Unit : dot"
printfn "   Branch : 0 - %A " (dot (4.0, 6.0) (5.0, 5.0) = (20.0, 30.0))
printfn " Unit : add"
printfn "   Branch : 0 - %A " (add (4.0,6.0) (4.0,6.0) = (8.0, 12.0))