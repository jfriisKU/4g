let polyLen (n : int) : float =
  /// Sum of len
  for i=0.0 to (n-1.0) do
    vec2d.len (cos(2.0*System.Math.PI*i/2.0),sin(2.0*System.Math.PI*i/2.0))
  /// This is your vector. i is not defined.