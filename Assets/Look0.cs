﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(new Vector3(0, transform.position.y, 0));
    }
}
