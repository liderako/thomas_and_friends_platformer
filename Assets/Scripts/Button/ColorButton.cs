﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{
    public GameObject door;

    private bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!isOpen && other.gameObject.layer == 12)
        {
            isOpen = true;
            Destroy(door);
        }
    }
}
