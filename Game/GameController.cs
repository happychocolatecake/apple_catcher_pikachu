using UnityEngine;


public class GameController : MonoBehaviour
{
    
    public GameObject startScreen;
    public GameObject gameScreen;

    public GameObject gameOverScreen;
    public pikachuController pikachuController;
    public AppleDuplicator appleDuplicator;
    public LifeHandling lifeHandling;

    private void Start() {
        startScreen.SetActive(true);
        gameScreen.SetActive(false);
        gameOverScreen.SetActive(false);

        pikachuController.onOutOfLives += handleGameOver;
    }

    void handleGameOver() {
        gameScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        pikachuController.setFinalCounterText();
    }

    public void restartGame() {
        
        Time.timeScale = 1f;
        gameScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        startScreen.SetActive(false);
        lifeHandling.resetHearts();

        pikachuController.lives = 3;
        pikachuController.counterText.text = "0";
        appleDuplicator.RunRestart();
    }
}
