SilverLining for Unity 1.9 

QUICK START GUIDE

1. Ensure any existing sky and directional light is removed from your scene. 
   Your camera's clear flags should be set to "Depth Only".
2. Import the SilverLining package
3. Open up the SilverLining folder in your project
4. Drag a SilverLiningPrefab into your scene
5. Open up your SilverLiningPrefab, and click on the _SilverLiningSky object.
6. Edit the script properties to set your desired time of day, location,
   and cloud properties such as coverage, extents, and position.
7. Hit "run!"

You may change the time of day and location dynamically at runtime. Changing
cloud properties such as cloud coverage may also be done at runtime, but may result
in dropped frames as the new clouds are generated.

Take care that the time zone you specify (given in hour offset from GMT) is consistent
with the longitude specified. Just specify all times in UTC with a GMT offset of 0 if
you don't want to worry about time zone issues.

Note, the Y dimension of the cumulus cloud layer indicates the variation in
the altitudes of clouds. The actual height of each cloud is determined
procedurally based on the coverage conditions requested.

You'll find performance is fast, but if you need even more, try reducing the
size of the cumulus cloud layer or reducing its density.

INTEGRATING SILVERLINING WITH YOUR CAMERAS

SilverLining will automatically adjust the far clip plane of your main camera to 100km,
to ensure our clouds, sun, etc. are visible. If you have more than one camera or your 
camera is not tagged as "MainCamera", you'll need to ensure your cameras' far clip planes 
are also extended to 100km or more.

SilverLining's sky dome will be drawn with a radius of 1000 meters by default. In some camera
arrangements, this can lead to the sky dome clipping terrain and other objects beyond 1000 meters.
If you are using SilverLining with our Triton 3D Ocean asset, this can also result in reflections on the
water not being present past a 1000 meter radius, which will look like an odd band of dark water 
toward the horizon.

To fix this, increase the _SilverLiningSky's scale (in its transform settings) from 1,000 to something 
larger, such as 50,000.

USING SILVERLINING WITH DIFFERENT UNIT CONVENTIONS (or, how to make the clouds bigger or smaller)

SilverLining assumes one world unit equals one meter. If you are using a
different convention, edit the unitScale parameter in the SilverLining.cs
script file.

So, for example, setting unitScale to 0.5 will make the clouds half as large.

Remember however that the cloud layer size settings will always be specified in meters. So if you
set your unitScale to 0.5, you also need to reduce your cloud layer sizes defined in the
_SilverLiningSky prefab by half as well. If you don't do this, SilverLining will try to fill 
too large of an area with too-small clouds, which could result in Unity creating more particles
than it can handle.

GETTING SUPPORT

Issues, questions, and feedback may be sent to support@sundog-soft.com.
Visit http://www.sundog-soft.com to learn more about our products.

WHAT'S NEW IN VERSION 1.9
- Fixed bug with changing unitScale parameter that could lead to sky colors going haywire

WHAT'S NEW IN VERSION 1.8
- If sky fog is enabled, SilverLining will automatically set an appropriate fog color
  for the time of day.
- New "cumulus brightness" proprety. This lets you create darker cumulus clouds to simulate
  storm clouds.
- Cumulus cloud density produced now more closely matches the coverage amount requested.
- Fixed error if no main camera is present.

WHAT'S NEW IN VERSION 1.7
- Moon orientation is now modeled
- Star directions of motion is corrected
- New "continous time advance" property. If checked, the time advance rate may also be
  set for time-lapse effects. If you have cumulus clouds in the scene, set the 
  "cloud updates per frame" setting to restrict the number of clouds re-lit per frame
  to maintain performance. Set this to -1 to relight every cloud every frame. The
  cloud updates per frame setting is only used when continuous time advancement is on.
- New properties for the the sun and moon size

WHAT'S NEW IN VERSION 1.6
- New Hosek-Wilkie sky model for more accurate sky colors (no more pink horizons!)
- Protect against array out of bounds exceptions from the stars
- Increase the brightness of the stars

WHAT'S NEW IN VERSION 1.5
- Don't show unpositioned sky assets in editor
- Don't force the clear flags of the main camera in our scripts
- Update cloud lighting if the RenderSettings ambient light changes at runtime

WHAT'S NEW IN VERSION 1.4
- Added circumsolar effects
- Higher-resolution sky sphere
- Toned down phase function effects when clouds are backlit
- Updated to Unity 3.5.5

WHAT'S NEW IN VERSION 1.3
- 2X performance boost! Over 250 FPS with cumulus clouds on PC
- Faster handling of changing fog conditions

WHAT'S NEW IN VERSION 1.2
- Lots of performance tuning
- Reverted use of Shuriken - legacy particles are 2X faster for what we're doing

WHAT'S NEW IN VERSION 1.1
- New stratus clouds added
- Migrated to Unity 3.5 Particle System ("Shuriken")
- Runtime modification of cloud properties now allowed
- Improved cumulus cloud lighting model
- Unused light sources are disabled
- Performance improvements (fewer particles, fewer skydome polygons)
- Wind-blown clouds now wrap around the bounds of the cloud layer, so clouds won't
  get blown away by the wind (the wrapCumulusClouds property enables this behavior.)
- Clouds near the edge of the cloud layer are faded to avoid popping artifacts
  (if wrapCumulusClouds is active.)
- Added applyFogToClouds and applyFogToSkyDome to disconnect RenderSettings'
  fog settings from SilverLining
- Added cumulusEllipseBounds to cull cumulus clouds outside an ellipse defined by the
  cloud layer dimensions (as opposed to a rectangle)
- Fixed calculation of moonlight

Copyright (c) 2011-2014 Sundog Software LLC. All rights reserved worldwide.