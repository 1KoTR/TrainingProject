using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMovement : MonoBehaviour
{
    [SerializeField] private float AngularSpeed;

    private void Start()
    {
        Destroy(gameObject, 15);
    }

    private void FixedUpdate()
    {
        transform.localEulerAngles += new Vector3(0, AngularSpeed, 0);
    }
}
