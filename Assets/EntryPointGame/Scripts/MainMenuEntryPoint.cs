using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuEntryPoint : MonoBehaviour
{
    private Injector injector;

    public void Awake()
    {
        injector.Init();
    }

}
