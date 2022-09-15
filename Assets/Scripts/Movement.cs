using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody2D RB2D;
    public float moveSpeed = 10f;
    public float collisionOffset = .001f;
    RaycastHit2D[] castCollisions;
    public ContactFilter2D movementFilter;

    // Start is called before the first frame update
    void Start()
    {
     RB2D = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movementInput;
        movementInput.y = Input.GetAxis("Vertical");
        movementInput.x = Input.GetAxis("Horizontal");
        bool success = TryMove(movementInput);
        print("movementInput: " + movementInput);
        print(success);
        if (!success)
            {
                success = TryMove(new Vector2(movementInput.x, 0));
                if (!success)
                {
                    success = TryMove(new Vector2(0, movementInput.y));
                }
            }
    }
    private bool TryMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            int count = RB2D.Cast(
                direction, // X and Y values between -1 and 1 that represent the direction from the body to look for collisions
                movementFilter, // the settings that determine where a collision can occur on such as layers to collide with
                castCollisions, // the list of collisions to store the found collisions into after the Cast is finished
                moveSpeed * Time.fixedDeltaTime + collisionOffset // the amount to cast equal to the movement plus an offset
            );
            if (count == 0)
            {
                RB2D.MovePosition(RB2D.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            }
            return false;
        }
        return false;
    }
}
