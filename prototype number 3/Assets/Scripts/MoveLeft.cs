using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 10;

    private PlayercontrollerScript _playerScript;

    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayercontrollerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerScript.isGameOver == false)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        
    }
}
