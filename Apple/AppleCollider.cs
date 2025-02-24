using UnityEngine;

public class AppleCollider : MonoBehaviour
{
    public pikachuController pikachuController;
    private bool collided = false;

    void OnTriggerEnter2D(Collider2D other){
        if (other.name == "pikachu_machine_0") {
            collided = true;
            Debug.Log("Collided");
            pikachuController.increaseCounter();
            
        }
        if(collided == false){
            if (other.name == "Barrier") {
                collided = false;
                Debug.Log("You have lost a life");
                pikachuController.loseLife();
        
            }
        }
    }
}

