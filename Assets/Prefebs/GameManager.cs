using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool game = true;

    public float restartDelay = 3f;

    public GameObject completeLevelUI;

    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
        
    }

    public void endGame(){
        if(game == true){
            game = false;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
