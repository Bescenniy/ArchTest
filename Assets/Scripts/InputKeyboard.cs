using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboard : MonoBehaviour
{
    public float xRaw;
    public float yRaw;

    public void Update()
    {
        xRaw = Input.GetAxisRaw("Horizontal");
        yRaw = Input.GetAxisRaw("Vertical");
        
    }
}
