using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public virtual void Collected(string fruitName)
    {
        Debug.Log("The fruit is collected!");
    }
}
