using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Only run animation while character in motion, stop movement when key up
public class PlayerCharacterScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float runSpeed;
    private bool isFacingRight;

    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!isFacingRight)
            {
                isFacingRight = true;
                // mirror the sprite
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            myRigidbody.velocity = Vector2.right * runSpeed;
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (isFacingRight)
            {
                isFacingRight = false;
                // mirror the sprite
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            myRigidbody.velocity = Vector2.left * runSpeed;
        }
    }
}
