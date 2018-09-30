(* Opgave 4g.0
 *
 * Gruppe 10:
 *	Jonas Friis
 *	Claes Heise
 *	Morten Risum Pedersen
 *)

module vec2d

///<summary>
///Calculates the length of a vector.
///</summary>
///<params name="(x, y)">
///A vector defined as a tuple (x, y).
///</params>
///<returns>
///The length of the vector as a float.
///</returns>
let len ((x, y) : (float * float)) : float =
    ((x*x)+(y*y))**(1.0/2.0)

///<summary>
///Calculates the angle of a vector, relative to the vector (1,0).
///</summary>
///<params name="(x, y)">
///A vector defined as a tuple (x, y).
///</params>
///<returns>
///The angle of the vector, relative to the vector (1,0), as a float.
///</returns>
let ang ((x, y) : (float * float)) : float =
    (atan2 y x)

///<summary>
///Scales a vector by multiplying a float with the vector.
///</summary>
///<params name="a">
///The factor to scale the vector by.
///</params>
///<params name="(x, y)">
///A vector defined as a tuple (x, y).
///</params>
///<returns>
///A scaled vector as a tuple.
///</returns>
let scale (a : float) ((x,y) : (float * float)) : (float * float) =
    ((x*a), (y*a))

///<summary>
///Adds two vectors.
///</summary>
///<params name="(x1, y1)">
///The first vector, defined as a tuple (x, y).
///</params>
///<params name="(x2, y2)">
///The second vector, defined as a tuple (x, y).
///</params>
///<returns>
///The sum of the two vectors, defined as a tuple (x, y).
///</returns>
///<remarks>
///Function takes up space greater than 80 characters.
///</remarks>
let add ((x1, y1) : (float * float)) ((x2, y2) : (float * float)) : (float * float) =
    (x1+x2, y1+y2)

///<summary>
///Calculates the dot product of two vectors.
///</summary>
///<params name="(x1, y1)">
///The first vector defined as a tuple (x, y).
///</params>
///<params name="(x2, y2)">
///The second vector defined as a tuple (x, y).
///</params>
///<returns>
///The dot product of two vectors as a float.
///</returns>
let dot ((x1, y1) : (float * float)) ((x2, y2) : (float * float)) : float =
    x1*x2+y1*y2

///Scraps.
///The arguments were given incorrectly, per the signature file.
///let scale ((x,y) : (float * float)) (a:float) : (float * float) =
///    ((x*a),(y*a))

///This produces the wrong result; a vector with two coordinates.
///let dot ((x1,y1) : (float * float)) ((x2,y2): (float * float)) : (float * float) =
///    ((x1*x2),(y1*y2))