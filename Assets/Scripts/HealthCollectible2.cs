using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible2 : MonoBehaviour
{
    [SerializeField]
    private int healthPuntuation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object that entered the trigger: " + other);
        if (other.CompareTag("Player"))
        {
            PlayerController controller = other.GetComponent<PlayerController>();
            if (controller != null)
            {
                controller.ChangeHealth(healthPuntuation);
                Debug.Log("Object that entered the trigger has got a : " + healthPuntuation);
                Destroy(gameObject);
            }
        }
    }
    
}
