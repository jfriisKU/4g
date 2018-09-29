/// Regardless, I have no idea what this function does.
/// It should return some sort of polygon length.
/// Really, it converts a float to an integer.

(*
 * I barely know what this function is supposed to do.
 * It should probably take the sum of the length of the vectors.
 * The vectors are defined as the cos and sin of times (?) in a circle.
 * The vectors are then the length of the vectors between the neighbouring points.
 * What the neighbouring points are has yet to be discovered.
 * Please send microscope and math.
 *)

/// FUNCTION SHOULD TAKE AN INT, NOT A FLOAT!
let polyLen (n : float) : float =
  let mutable i : float = 0.0
  let mutable s : float = 0.0
  while i <= (n-1.0) do
    s <- s + (vec2d.len (cos(2.0*System.Math.PI*i/2.0),sin(2.0*System.Math.PI*i/2.0)))
    i <- i + 1.0
  s

printfn "%g" (polyLen 48290.248932)