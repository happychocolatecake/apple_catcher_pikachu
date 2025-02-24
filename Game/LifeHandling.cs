using UnityEngine;

public class LifeHandling : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public void checkAndRemoveHeart(){

            if (heart1.activeInHierarchy == true) {
                heart1.SetActive(false);
            }
            else if (heart2.activeInHierarchy  == true) {
                heart2.SetActive(false);
            }
            else {
                heart3.SetActive(false);
            }
    }

    public void resetHearts() {
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);
    }
    
    
}
