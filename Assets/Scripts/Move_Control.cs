using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move_Control : MonoBehaviour
{
    CharacterController player;
    PlayerControls controls;
    Vector2 move;
    private Vector3 moveDirection;

    [SerializeField] public float speed = 15.0f;
    public float gravity = 20.0f;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Awake()
    {
        controls = new PlayerControls();
        controls.Gameplay.Grow.performed += context => Grow();

        controls.Gameplay.Move.performed += context => move = context.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += context => move = Vector2.zero;

    }


    void Grow()
    {
        transform.localScale *= 1.1f;
    }

    void Update()
    {
        if (player.isGrounded)
        {
            moveDirection = new Vector3(move.x, 0.0f, move.y);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
        }

        //move the player
        moveDirection.y -= gravity * Time.deltaTime;
        player.Move(moveDirection * Time.deltaTime);




        // Vector3 m = new Vector3(move.x, 0.0f, move.y) * Time.deltaTime * speed;
        // player.Move(m);
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }

}
