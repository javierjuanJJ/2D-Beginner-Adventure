using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public InputAction MoveAction;
    [SerializeField] private float speed;
Rigidbody2D rigidbody2d;
  Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();  
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
    }
    
    
    void FixedUpdate()
      {
         Vector2 position = (Vector2)rigidbody2d.position + move * (speed * Time.deltaTime);
         rigidbody2d.MovePosition(position);
      }
    
}
