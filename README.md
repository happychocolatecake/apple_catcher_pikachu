# apple_catcher_pikachu

this game is made up of a lot of different scripts in order to create a game where apples fall from the sky, and pikachu has three lives in order to catch as many apples as he can. Once three lives are gone

pikachuController.js:
This script handles the pikachu movement, using Input.mousePosition and transform.position to make the pikachu follow the cursor, keeping its y and z values the same and constraining it to keep the pikachu moving along the x-axis within the correct bounds.
It also handles lives and losing them but it uses another script for handling the image change of the healthbar
(LifeHandling.js)

gameController.js:
handles the game screen loading not loading, directs to functions that are suposed to occur when the event losing a life is triggered

appleDuplicator.js:
using prefabs creates apples infinitely until the pikachus lives run out.

appleCollider.js:
uses boxcollider 2D and detects whether it hits the pikachus collider at all or doesnt hit the pikachu and only hits the barrier instead, then responds accordingly as the apple fell without the pikachu catching it.


