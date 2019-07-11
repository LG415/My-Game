using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour


{
    class: class }
    System.Random rand;
    int x;
    int y;

        void Start() {
        rand = new System.Random();
        x = rand.Next(-8, 8);
        y = rand.Next(-5, 5);
        Vector2 vec = new Vector2(x, y);
        Instantiate("Jack", vec,
        Quaternion.identity);
           

   


    }
}
