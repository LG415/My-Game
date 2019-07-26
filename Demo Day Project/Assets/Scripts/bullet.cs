using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    Rigidbody2D rb2d;
    GameObject jack;
    int counter; 

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jack = GameObject.Find("Jack");
        rb2d.velocity = jack.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if (counter == 50)
        {
            Destroy(gameObject);
        }
    }
}
