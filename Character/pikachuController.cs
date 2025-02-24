using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class pikachuController : MonoBehaviour
{
    public LifeHandling lifeHandling;

    public Sprite pikachu;
    public float speed;
    public Text counterText;
    public Text finalCounterText;

    public int lives;
    public event Action onOutOfLives;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseCoord = Input.mousePosition;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mouseCoord);

        mousePosition.z = transform.position.z;
        mousePosition.y = transform.position.y;

        
        if (mousePosition.x <= 8 && mousePosition.x >= -8) {
            transform.position = mousePosition;
        }
        
    }

    public void increaseCounter() {
        int currentNumber = int.Parse(counterText.text);
        int nextNumber = currentNumber + 1;
        counterText.text = nextNumber.ToString();
    }

    public void setFinalCounterText() {
        finalCounterText.text = counterText.text;
    }

    public void loseLife() {
        lives = lives - 1;
        lifeHandling.checkAndRemoveHeart();

        if (lives == 0) {
            Time.timeScale = 0f; //this should pause the game
            onOutOfLives();
        }
    }
}
