using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FruitController : EnemyController // INHERITANCE
{

    [SerializeField] private float _velocity = 1f; //

    private Rigidbody _fruitRb;
    [SerializeField] private int _score = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        _fruitRb = GetComponent<Rigidbody>();
        _fruitRb.velocity = new Vector3(0, -_velocity, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3)
        {
            Destroy(gameObject);
        }
    }

    public override void Collected(string fruit) // POLYMORPHISM
    {
        Debug.Log("The" + fruit + " is collected!");
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            Collected(gameObject.name);

            GameManager.Instance.Score += _score;
        }
    }
}
