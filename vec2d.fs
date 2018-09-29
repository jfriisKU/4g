(* Opgave 4g.0
 *
 * Gruppe 10:
 *	Jonas Friis
 *	Claes Heise
 *	Morten Risum Pedersen
 *)

module vec2d

let len ((x, y) : (float * float)) : float =
    ((x*x)+(y*y))**(1.0/2.0)

let ang ((x, y) : (float * float)) : float =
    (atan2 y x)

/// The arguments were given incorrectly, per the signature file.
///let scale ((x,y) : (float * float)) (a:float) : (float * float) =
///    ((x*a),(y*a))

let scale (a : float) ((x,y) : (float * float)) : (float * float) =
    ((x*a), (y*a))

let add ((x1, y1) : (float * float)) ((x2, y2) : (float * float)) : (float * float) =
    (x1+x2, y1+y2)

///This produces the wrong result; a vector with two coordinates.
///let dot ((x1,y1) : (float * float)) ((x2,y2): (float * float)) : (float * float) =
///    ((x1*x2),(y1*y2))

let dot ((x1, y1) : (float * float)) ((x2, y2) : (float * float)) : float =
    x1*x2+y1*y2
