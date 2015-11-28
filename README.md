# Unity Cardboard photosphere example 
A simple Unity project template for viewing photospheres / 360-degree photos using Google Cardboard

There are two methods demonstrated here:

  1. Use of a double sided unlit shader so that both sides of the sphere are visible.

  2. Use of a sphere mesh with the normals flipped so that the mesh is visible from inside the sphere.

The default Unity Sphere primitive is UV mapped with an equirectangular projection, so most common photospheres should work. When adding your own photosphere images, make sure you set the import size of the image as high as possible (8192).

The Cardboard plugin for Unity (v0.5.2) is included - if you want to update to different version, delete the Cardboard and Plugins folders and import the new version from here: https://github.com/googlesamples/cardboard-unity

There are some small changes made to the default Cardboard prefab settings:

  * On CardboardHead, Track Position is turned off (we only want rotation)
  * On StereoController, we reduce Stereo Multiplier to zero - this makes both eyes see the same image.
  * The Camera Far Clipping Plane is set to 1000, and the Sphere has a radius of 999 - this means that the inside of the sphere will be distant, so even if Stereo Multiplier is non-zero there will be no detectable stereo parallax.

Stereo 3D photospheres should be possible (create two spheres, use Layers so left/right cameras only see one sphere) but aren't yet demonstrated.

## License
The code is provided under the Apache License, Version 2.0.

The "Double Arch Photosphere" by Mark Doliner (https://www.flickr.com/photos/markdoliner/14094296347) is under a Creative Commons Attribution 2.0 Generic License [CC BY 2.0](https://creativecommons.org/licenses/by/2.0/).

The LyonvilleSpring__AndrewPerry__PublicDomain images is provided under a CC0 license (https://creativecommons.org/publicdomain/zero/1.0/), and is dedicated to the public domain.

