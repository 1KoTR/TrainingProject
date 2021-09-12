using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChanger : MonoBehaviour
{
    [SerializeField] private Transform _point;

    [SerializeField] private GameObject _door;

    private void Start()
    {
        RaycastHit[] hits = Physics.RaycastAll(_point.position, _point.forward, 2.5f);
        if (hits.Length == 2)
        {
            foreach (var item in hits)
            {
                Destroy(item.transform.gameObject);
            }
            var door = Instantiate(_door, transform.position + new Vector3(0, 0, -10), transform.rotation);
        }
    }
}
