using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSpawnerManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Points;
    [SerializeField] private Transform Parent;

    [SerializeField] private GameObject SingleWall;

    private void Start()
    {
        for (int i = 0; i < Points.Length; i++)
        {
            var transform = Points[i].transform;
            var spawnObj = Instantiate(SingleWall, transform.position, Quaternion.Euler(new Vector3(0, 90 * Random.Range(0, 4), 0)));
            spawnObj.transform.SetParent(Parent);
            spawnObj.name = "Wall";
        }
    }
}
