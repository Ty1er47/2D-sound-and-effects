using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject obstaclePreFab;
    private Vector3 _spawnPos = new Vector3(12, -3.25f, 0);
    private float _startDelay = 2;
    private float _repeatRate = 3;

    private PlayercontrollerScript _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayercontrollerScript>();
        InvokeRepeating("SpawnObstacle", _startDelay, _repeatRate);
    }

    // Update is called once per frame
    void SpawnObstacle()
   { if(_playerScript.isGameOver == false)
    {
        Instantiate(obstaclePreFab, _spawnPos, obstaclePreFab.transform.rotation);
    }
   }
}
