using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    Rigidbody2D rb2d;
    public GameObject jack;
    int counter;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jack = GameObject.FindWithTag("Player");
        rb2d.velocity =  new Vector2((transform.position.x - jack.transform.position.x) * 10, 
        (transform.position.y - jack.transform.position.y) * 10);
    }

    // Update is called once per frame
    void Update() 
    {
        counter++;
        if (counter == 60) 
        {
            Destroy(gameObject);
        }

    }
}
