using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Control : MonoBehaviour
{
    [SerializeField] GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float charPosX = player.transform.position.x;
        float charPosZ = player.transform.position.z+20;


        transform.position = new Vector3(charPosX, -15, charPosZ);
    }
}
