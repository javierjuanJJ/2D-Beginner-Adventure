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
    
    
    // Variables related to temporary invincibility
    public float timeInvincible = 2.0f;
    bool isInvincible;
    float damageCooldown;

    // Variables related to the health system
    public int maxHealth = 5;
    int currentHealth;

    public int health
    {
        get { return currentHealth; }
    }

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        // currentHealth = 1;
        currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount)
    {

        if (amount < 0 && !isInvincible)
        {
            isInvincible = true;
            damageCooldown = timeInvincible;
        }
        
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
        UIHandler2.instance.SetHealthValue(currentHealth / (float)maxHealth);
    }


    // Update is called once per frame
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        
        if (isInvincible)
        {
            damageCooldown -= Time.deltaTime;
            if (damageCooldown < 0)
            {
                isInvincible = false;
            }
        }
        
    }


    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * (speed * Time.deltaTime);
        rigidbody2d.MovePosition(position);
    }
}