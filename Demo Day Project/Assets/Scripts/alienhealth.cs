using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienhealth : MonoBehaviour
{
    playercontroller pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.FindWithTag("Player").GetComponent<playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "bullet")
        {
            pc.killed++;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
