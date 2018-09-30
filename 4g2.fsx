(* Opgave 4g.2
 *
 * Gruppe 10:
 *  Jonas Friis
 *  Claes Heise
 *  Morten Risum Pedersen
 *)

/// Regardless, I have no idea what this function does.
/// It should return some sort of polygon length.
/// Really, it converts a float to an integer.

(*
 * I barely know what this function is supposed to do.
 * It should probably take the sum of the length of the vectors.
 * The vectors are defined as the cos and sin of times (?) in a circle.
 * They are then the length of the vectors between the neighbouring points.
 * What the neighbouring points are has yet to be discovered.
 * Please send microscope and math.
 *)

(* (a) *)

///<summary>
///Approximates the cirfumference of a circle with radius 1 with steps n.
///</summary>
///<params name="n">
///The amount of vectors to use for calculation.
///Larger n produce more accurate results.
///</params>
///<returns>
///The length of the polygon as a float.
///</returns>
///<remarks>
///DELETE IF NO REMARKS. /////////////////////////////////////////////////////!
///</remarks>
let polyLen (n : float) : float =
  let mutable i : float = 0.0
  let mutable s : float = 0.0
  while i <= (n-1.0) do
    s <- s + (vec2d.len (cos(2.0*System.Math.PI*i/2.0),sin(2.0*System.Math.PI*i/2.0)))
    i <- i + 1.0
  s

printfn "%g" (polyLen 48290.248932)

///Should be included in the polyLen function.
///Consider issues arising from taking variable n (for row lengt, not implm.).
let lengthTable (n : int) : string =
  let mutable strt = ""
  strt <- strt + "\n   n polyLen circumference\n"
  /// Row Control (modify to work with i = (n-10) to n)
  for i = 1 to 10 do
    /// Prints leftmost column
    strt <- strt + sprintf "%4i" i
    /// Column Control
    strt <- strt + sprintf " %7g %13g" (3.14) (6.28)
    strt <- strt + sprintf "\n"
  sprintf "%s" strt

printf "%s" (lengthTable 10)

(* (b) *)