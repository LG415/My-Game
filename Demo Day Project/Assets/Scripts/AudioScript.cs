﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

    public AudioClip MusicClip;

    public AudioSource MusicSource;

    //Use this for initialization
    void Start() {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }

   
}
