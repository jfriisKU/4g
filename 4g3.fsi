(* Opgave 4g.3
 *
 * Gruppe 10:
 *  Jonas Friis
 *  Claes Heise
 *  Morten Risum Pedersen
 *)

/// A 2 dimensional vector library .
/// Vectors are represented as pairs of floats
module vec2d
/// The length of a vector
val len : float -> float -> float
/// The angle of a vector
val ang : float -> float -> float
/// Multiplication of a float and a vector
val scale : float -> float -> float -> string
/// Addition of two vectors
val add : float -> float -> float -> float -> string
/// Dot product of two vectors
val dot : float -> float -> float -> float -> float

(*
 * len, ang og dot er lette at implementere uden tupler, hvis programmet der skal bruge
 * funktionerne ikke selv regner med tupler.
 * Brugeren skal blot holde styr på, hvor de skal lave deres input.
 *
 * scale og add returnerer en string, hvori to floats står, i stedet for tupler.
 * Det kræver at programmet, der kalder funktionerne ved, de skal omregne fra strings.
 *)