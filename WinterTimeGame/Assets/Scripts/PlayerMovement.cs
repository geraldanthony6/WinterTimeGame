using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    /*[SerializeField] private float moveSpeed = 5f;

    [SerializeField] private float jumpForce = 5f;

    private PlayerInputActions _inputActions;*/

    [SerializeField] private Vector2 playerOneMoveInput;
    
    [SerializeField] private Vector2 playerTwoMoveInput;

    [SerializeField] private Rigidbody2D playerRigidBody;

    [SerializeField] private bool bIsPlayerOne;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Apply movement
        if (bIsPlayerOne)
        {
            Vector2 moveVector = new Vector3(playerOneMoveInput.x, playerOneMoveInput.y) * 5.0f * Time.deltaTime;
            playerRigidBody.MovePosition(playerRigidBody.position + moveVector);
        }
        else
        {
            Vector2 moveVector = new Vector3(playerTwoMoveInput.x, playerTwoMoveInput.y) * 5.0f * Time.deltaTime;
            playerRigidBody.MovePosition(playerRigidBody.position + moveVector);
        }

    }

    public void OnPlayerJump()
    {
        Debug.Log("Player Jump");
        playerRigidBody.AddForce(Vector2.up * 100.0f, ForceMode2D.Impulse);
    }

    public void OnPlayerOneMove(InputValue Value)
    {
        Debug.Log(Value.Get<Vector2>());
        playerOneMoveInput = Value.Get<Vector2>();
    }
    
    public void OnPlayerTwoMove(InputValue Value)
    {
        Debug.Log(Value.Get<Vector2>());
        playerTwoMoveInput = Value.Get<Vector2>();
    }
}
