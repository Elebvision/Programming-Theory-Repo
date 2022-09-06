using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private float xRange = 12f;
    private float yRange = 14f;
  

    [SerializeField] private GameObject[] _fruitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFruit", 1, 1); // ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomFruit()
    {
        int randomFruitIndex = Random.Range(0, _fruitPrefab.Length);
        float randomXRange = Random.Range(-xRange, xRange);
        Instantiate(_fruitPrefab[randomFruitIndex], new Vector3(randomXRange, yRange, 0), _fruitPrefab[randomFruitIndex].gameObject.transform.rotation);

    }

}
