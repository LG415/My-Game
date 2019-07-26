using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    private Rigidbody2D rb2d;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(bullet, new Vector2(self.transform.position.x -2, self.transform.position.y), Quaternion.identity);
            rb2d = bullet.GetComponent<Rigidbody2D>();
        }
    }
}
