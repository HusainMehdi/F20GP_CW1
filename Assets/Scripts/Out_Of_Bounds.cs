using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Out_Of_Bounds : MonoBehaviour
{
    public Text gameOver;



    void OnTriggerEnter(Collider other) {

        Debug.Log("Game Over");
        gameOver.text = "GAME OVER";
        Time.timeScale = 0;
        
    }
}
