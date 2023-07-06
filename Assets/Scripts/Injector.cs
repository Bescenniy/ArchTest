using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injector 
{
    private Character _character;
    private InputKeyboard _inputKeyboard;

    public void Init()
    {
        IPlayerControllerService playerControllerService;

        playerControllerService = new PlayerControllerService(_inputKeyboard);
        _character.Inject(playerControllerService);
    }
}
