using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerService : IPlayerControllerService
{
    private readonly InputKeyboard _inputKeyboard;
    public PlayerControllerService(InputKeyboard inputKeyboard)
    {_inputKeyboard = inputKeyboard;}

    public float GetAxisRowX()
    {
        return _inputKeyboard.xRaw;
    }

    public float GetAxisRowY()
    {
        return _inputKeyboard.yRaw;
    }
    private void Update()
    {
        
    }
}
