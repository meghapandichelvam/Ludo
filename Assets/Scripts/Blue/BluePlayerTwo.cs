﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerTwo : MonoBehaviour
{
    public static string bluePlayerTwoColName;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blocks")
        {
            bluePlayerTwoColName = col.gameObject.name;
            if (col.gameObject.name.Contains("Blue House"))
                SoundManager.safeHouseAudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        bluePlayerTwoColName = "none";
    }
}