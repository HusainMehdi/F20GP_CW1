using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    [SerializeField] float cameraOffset = 15.0f;
    [SerializeField] GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float charPosX = player.transform.position.x;
        float charPosZ = player.transform.position.z;


        transform.position = new Vector3(charPosX, cameraOffset, charPosZ);
    }
}
