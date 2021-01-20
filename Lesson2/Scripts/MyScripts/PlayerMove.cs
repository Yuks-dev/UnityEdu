using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int hp = 10;

    [SerializeField] private float speed = 6;
    [SerializeField] private GameObject bullet = null;
    [SerializeField] private Transform bulletStartPosition = null;

    private Vector3 direction = Vector3.zero;
    private bool fire = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        fire = true;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        
    }

    void FixedUpdate()
    {
        var s = direction * speed * Time.fixedDeltaTime;
        transform.Translate(s);

        if (fire)
        Fire();
    }

    private void Fire()
    {
        fire = false;
        var bul = Instantiate(bullet, bulletStartPosition.position, Quaternion.identity);
    }
}
