# PF-LawnMowers
A fleet of robotic lawn mowers are to be deployed to trim the grass of a large lawn. This lawn, which is perfectly rectangular, must be navigated by the mowers so that they can maintain an even height of grass.  The lawn is bordered on all sides by gardens that contain rare plants.  A mower's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points.  The lawn is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the mower is in the bottom left corner and facing North.  In order to control a mower, the remote controller sends a simple string of letters.  The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the mower spin 90 degrees left or right respectively, without moving from its current spot.  'M' means move forward one grid point, and maintain the same heading.  Assume that the square directly North from (x, y) is (x, y+1).-

About "LAWN MOWERS" APPLICATION.

Intro.

It was used as a basic project "ASP.NET Web Application" to respond to the interaction of the user through a GUI, This way you can run the simulation process "n" times.
Any type of error will be handled as an exception that invites the user to enter a valid sequence.

Assumptions.

You can only move forward if the next position is empty, if there is a mower in front, you should wait for receive an order of rotation "L or R".
The pruners will only be able to cross the established land, since in each movement the edges are verified.

Execution.

The solution was made in 12 hours.
