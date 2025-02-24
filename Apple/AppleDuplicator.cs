using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleDuplicator : MonoBehaviour 
{
    public GameObject myPrefabApple;
    public GameObject helpMessage;
    public pikachuController pikachuController;
    public int randomAmountofApples;

    public LifeHandling lifeHandling;

    void Start()
    {
        randomAmountofApples = Random.Range(20,25);
        float randomX = Random.Range(-8, 8);
        float randomY = Random.Range(-1,0);
        StartCoroutine(introductionToGame());
    }

    public IEnumerator createRandomApples() {
        
        //infinity
        while (true){
                yield return new WaitForSeconds(1f);
                StartCoroutine(createApple());
        }
        
    }

    public IEnumerator createApple() {

        yield return new WaitForSeconds(2f);

        float randomX = Random.Range(-8, 8);
        float randomY = Random.Range(4.5f,7);
        float randomTimeWait = Random.Range(1,2);

        yield return new WaitForSeconds(randomTimeWait);
        Instantiate(myPrefabApple, new Vector3(randomX, randomY, 0), Quaternion.identity);
    }

    public void RestartApples() {
        pikachuController.lives = 3;
        lifeHandling.resetHearts();
        pikachuController.counterText.text = "0";

        StopAllCoroutines();
        StartCoroutine(createRandomApples());
        
    }

    public IEnumerator introductionToGame(){
        yield return new WaitForSeconds(1f);
        helpMessage.SetActive(true);
        yield return new WaitForSeconds(3f);
        helpMessage.SetActive(false);
        RestartApples();
    }

    public void RunRestart() {
        StartCoroutine(introductionToGame());
    }

}

