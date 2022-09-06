using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _speed = 3f;
    private float _maxMove = 11f;
    
    // Update is called once per frame
    void Update()
    {
        float rightLeftInput = Input.GetAxis("Horizontal") * _speed;

        if (transform.position.x < -_maxMove)
        {
            transform.position = new Vector3(-_maxMove, 0, 0);
        }
        else if (transform.position.x > _maxMove)
        {
            transform.position = new Vector3(_maxMove, 0, 0);
        }


        transform.Translate(Vector3.right * rightLeftInput * Time.deltaTime);
        
       
    }
}
