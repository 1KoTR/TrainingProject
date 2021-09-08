using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnerManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Points;
    [SerializeField] private Transform Parent;

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject BotPlayer;

    private void Start()
    {
        var l = Points.Length;

        var rnd = new System.Random().Next(l);
        Spawn(Player, "Player", rnd);

        for (int i = 0; i < l; i++)
            if (i != rnd)
                Spawn(BotPlayer, "BotPlayer", i);
    }

    private void Spawn(GameObject obj, string name, int num)
    {
        var transform = Points[num].transform;
        var spawnObj = Instantiate(obj, transform.position, transform.rotation);
        spawnObj.transform.SetParent(Parent);
        spawnObj.name = name;
    }
}
