using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text bigText;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("You win!");
        bigText.text = "YOU WIN!";
        Time.timeScale = 0;

    }
}