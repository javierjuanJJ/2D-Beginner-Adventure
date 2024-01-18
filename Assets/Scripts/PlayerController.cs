using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public InputAction MoveAction;
    [SerializeField] private float speed;


    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();  
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * (speed * Time.deltaTime);
        transform.position = position;
    }
}
