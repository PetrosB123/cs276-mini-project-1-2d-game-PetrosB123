# Fish Farce

## Play the Game
**Unity Play Link**: [Your Unity Play URL]

## Game Overview
As a fish, it is your job to not get hit by the shells, they will obliterate you. Your goal is to pop bubbles as they rise up on the screen while avoiding the shells. The more bubbles you pop, the higher score you get. Be careful though, the shells can also pop the bubbles.

### Controls
- Movement: Mouse click

### How to Play
Avoid getting hit by the shells and pop bubbles to get higher score!

## Base Game Implementation

### Completion Status
- [x] Set up your 2D game world
- [x] Make a flying obstacle prefab
- [x] Random obstacle size, direction, and speed
- [x] Steer the player
- [x] Add a scoring system
- [x] Restart the game with a bang

### Known Bugs
- Currently no known bugs! (let me know if you find any!)

### Limitations
- Due to the warping at the edge of the screen, the collision for the edge of the screen in the corners is slightly inwards from the edge of the cameras view.
- Due to the abnormal shape of the shells hitbox, they sometimes stop bouncing

## Extensions Implemented

### 1. [Change Your Entire Game Concept] (3 points)
**Implementation**: Fish dodging shells
**Game Impact**: Visually different than rocket and asteroids
**Technical Details**: Different sprites
**Known Issues**: None

### 2. [Swap Out Your Sprites] (3 points)
**Implementation**: Drew sprites for fish, shells, and bubbles (both unpopped and popped states)
**Game Impact**: Visually more interesting than blobs of color
**Technical Details**: Drew sprites and implemented them into the game
**Known Issues**: None

### 3. [Increase Difficulty Over Time] (5 points)
**Implementation**: Increased bounciness
**Game Impact**: Keeps the shells bouncing for longer
**Technical Details**: Set the physics materials bounciness to 1.05
**Known Issues**: Shells are weirdly shaped so they stop bouncing?

### 4. [Add Sound Effects and Background Music] (5 points)
**Implementation**: Added background sound and sound effects
**Game Impact**: Keeps player engaged with sound
**Technical Details**: Added an underwater ambience sound, a crt hum sound (for fun), bubble popping sound, and a slightly gruesome fish exploding sound
**Known Issues**: None

### 5. [Destroy the Borders on Game Over ] (4 points)
**Implementation**: Borders deactivate when player dies
**Game Impact**: Looks cool on the screen
**Technical Details**: When the player dies, the borders are set to not be active
**Known Issues**: None

### [Other Additions]
- Added a system for bubbles to randomly spawn at the bottom of the screen and rise up
- Changed scoring system to points based on popping bubbles that randomly rise from the bottom of the screen
- Added a screen effect shader to make it look like a CRT (credit to MichaelsGameLab on YouTube for the tutorial)

## Credits
- Bubble Pop by TheBuilder15 -- https://freesound.org/s/411462/ -- License: Creative Commons 0
- Underwater Ambience by Fission9 -- https://freesound.org/s/504641/ -- License: Creative Commons 0
- Gut Rip (Unbladed) by magnuswaker -- https://freesound.org/s/530919/ -- License: Creative Commons 0
- CRT high pitch tone by LukaCafuka -- https://freesound.org/s/751392/ -- License: Creative Commons 0
- CRT Shader Tutorial by MichaelsGameLab -- https://www.youtube.com/watch?v=lOyb0_rFA1A

## Reflection
**Total Points Claimed**: [Base: 80% + Extensions: 16% = 96%]
**Challenges**: Drawing is not my strong suit but I made it work using reference images.
**Learning Outcomes**: I really enjoyed learning the screen shader effects, that was really interesting. I also enjoyed thinking about how I was going to make the bubbles work and implementing those, the pop effect really makes it satisfying.

## Development Notes
None