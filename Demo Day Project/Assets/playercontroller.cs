using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rb2d;
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out the movement
    private Vector3 velocity = Vector3.zero;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 targetVelocity = new Vector2(moveHorizontal * 10f, moveVertical * 10f);
        rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, targetVelocity, ref velocity, m_MovementSmoothing);

        if (System.Math.Abs(moveHorizontal) > 0 && rb2d.velocity.y == 0)
        {
            if (moveHorizontal < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }

            anim.Play("Jack run gun");
        }
        else if (rb2d.velocity.y == 0) 
        {
            anim.Play("idle");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("jump");
            rb2d.AddForce(new Vector2(0, 500f));
        }
    }


}
