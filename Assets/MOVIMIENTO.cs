using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMIENTO : MonoBehaviour
{
    Rigidbody2D RB2D;
    SpriteRenderer SR;
    Vector3 direction;
    float MovementSpeed = 1;

    float movVel = 5f;
    float velX;
    float velY;
    bool vista = true;
    Rigidbody2D rigCuerpo;

    public float Salto = 6f;
    bool enGround = false;

    // Start is called before the first frame update
    void Start()
    {
         RB2D = GetComponent<Rigidbody2D>();
         SR = GetComponent<SpriteRenderer>();
         direction = new Vector3 (0,0,0);

         rigCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    void Update()
    {
        transform.position += direction * Time.deltaTime * MovementSpeed;

        velX = Input.GetAxisRaw("Horizontal");
        velY = rigCuerpo.velocity.y;
        rigCuerpo.velocity = new Vector2 (velX * movVel, velY);

        if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.W))
        {
            if(enGround)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, Salto); 
            }
        }
    }

    void OnTriggerEnter2D()
    {
    enGround = true;
    }

    void OnTriggerExit2D()
    {
    enGround = false;
    }

    void LateUpdate()
    {
        Vector3 localScale = transform.localScale;
        if (velX > 0)
        {
            vista = true;   
        } 

        else if (velX < 0)
        {
            vista = false;  
        }

        if (((vista) && (localScale.x < 0)) || ((!vista) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }
  
}
