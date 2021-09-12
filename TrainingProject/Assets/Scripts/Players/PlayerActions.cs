using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private KeyCode SpawnMine;
    [SerializeField] private KeyCode Shoot;

    [SerializeField] private Transform Parent;

    [SerializeField] private Transform MineSpawner;
    [SerializeField] private Transform bulletSpawner;

    [SerializeField] private GameObject Mine;

    [SerializeField] private float Distance;
    [SerializeField] private float DestroyTime;
    private void Update()
    {
        if (Input.GetKeyDown(SpawnMine))
        {
            var hit = new RaycastHit();
            if (Physics.Raycast(MineSpawner.position, MineSpawner.forward, out hit, Distance))
            {
                if (hit.transform.tag == "Wall")
                {
                    var mine = Instantiate(Mine, hit.point, transform.rotation);
                    mine.transform.SetParent(Parent);
                    mine.name = "Mine";

                    Destroy(hit.transform.gameObject, DestroyTime);
                }
            }
        }
    }
}
