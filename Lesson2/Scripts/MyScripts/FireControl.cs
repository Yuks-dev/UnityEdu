using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    public int hp = 10;
    [SerializeField] private GameObject bullet = null;
    [SerializeField] private Transform bulletStartPosition = null;

    private bool fire = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) fire = true;
    }

    void FixedUpdate()
    {
        if (fire) Fire();
    }

    private void Fire()
    {
        fire = false;
        var bul = Instantiate(bullet, bulletStartPosition.position, Quaternion.identity);
    }
}
