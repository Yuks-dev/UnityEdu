using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp = 100;
    private PlayerMove player = null;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
            Death();
    }

    private void Death ()
    {
        Destroy(gameObject, 1);
    }

}
