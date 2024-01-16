using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            position.x += speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            position.y += speed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            position.x -= speed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            position.y -= speed;
        }
        if (Input.GetKeyDown(KeyCode.Z) && speed > 0)
        {
            speed += 1;
        }
        if (Input.GetKeyDown(KeyCode.Y) && speed > 1 )
        {
            speed -= 1;
        }
        transform.position = position;
    }
}
