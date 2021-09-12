using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private float DestroyTime;

    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
}
