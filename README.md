# apple_catcher_pikachu

### Summary
this game is made up of a lot of different scripts in order to create a game where apples fall from the sky, and pikachu has three lives to catch as many apples as he can. If he lets a single apple touch the floor without him touching it he loses a life. Once three lives are gone the game is over and the player has the option to start the game again. This is possible through the use of unity's onhit events with button elements to control the screens. (alongside the gameController.cs script to actually handle restarting the values). Pikachu can be moved left to right with the use of the cursor.

### Scripts 
- pikachuController.cs:
This script handles the pikachu movement, using Input.mousePosition and transform.position to make the pikachu follow the cursor, keeping its y and z values the same and constraining it to keep the pikachu moving along the x-axis within the correct bounds.
It also handles lives and losing them but it uses another script for handling the image change of the healthbar
(LifeHandling.cs)

- gameController.cs:
handles the game screen loading not loading, directs to functions that are suposed to occur when the event losing a life is triggered

- appleDuplicator.cs:
using prefabs creates apples infinitely until the pikachus lives run out.

- appleCollider.cs:
uses boxcollider 2D and detects whether it hits the pikachus collider at all or doesnt hit the pikachu and only hits the barrier instead, then responds accordingly as the apple fell without the pikachu catching it.

### Images

<img width="595" alt="image" src="https://github.com/user-attachments/assets/ccd31e36-d38d-465f-a0ea-8439cf20074b" />
<img width="594" alt="image" src="https://github.com/user-attachments/assets/d5cc2066-bb6d-4c2c-ac38-fe304d2a03e0" />
<img width="597" alt="image" src="https://github.com/user-attachments/assets/f32dc6e4-8dd1-4602-b2b4-2485620e529e" />



