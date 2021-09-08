using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpawnerManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Points;
    [SerializeField] private GameObject[] Upgrades;
    [SerializeField] private Transform Parent;

    [SerializeField] private float Coldown;

    [SerializeField] private Vector3 Offset;

    private void FixedUpdate()
    {

    }
}
