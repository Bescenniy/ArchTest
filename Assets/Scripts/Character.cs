using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
   private int _speedForce = 10;

    private IPlayerControllerService _playerControllerService;
    public void Inject(IPlayerControllerService playerControllerService)
    {
        _playerControllerService = playerControllerService; 
    }
    private void Update()
    {
      Move();
    }

    public void Move()
    {
        float x = _playerControllerService.GetAxisRowX();
        float y = _playerControllerService.GetAxisRowY();
        Debug.Log($"input keyboard {x}:{y}");
        Vector3 newDirection = new Vector3(x, 0, y);
        transform.position = newDirection.normalized * _speedForce * Time.deltaTime;       
    }
}
