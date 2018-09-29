All .fsx files require the vec2d.fs library, which requires the vec2d.fsi signature.
In order to test files, these must be executed using one of the following sequences:

INTERACTIVE:
fsharpi vec2d.fsi vec2d.fs [file].fsx
COMPILE:
fsharpc vec2d.fsi vec2d.fs [file].fsx && (mono on Linux) [file].exe