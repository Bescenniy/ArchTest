using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoostrapEntryPoint : MonoBehaviour
{

    private IEnumerator Start()
    {

        //intitialize all service this point
       

        var loadingDuratuon = 10f;
        while (loadingDuratuon > 0f)
        {
            loadingDuratuon -= Time.deltaTime;
            Debug.Log($"Loading all services {loadingDuratuon}");
            yield return null;           
        }

        Debug.Log("All services initialized");
        SceneManager.LoadScene("MainMenu");

    }

}
