using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //[SerializeField] Transform target;
    PlayerHealth target;
    [SerializeField] float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

/*
    public void OnDamageTaken()
    {
        Debug.Log(name + "I also know that we took damage");
    }
*/
    public void AttackHitEvent()
    {
        if (target == null) return;
        //target.GetComponent<PlayerHealth>().TakeDamage(damage);
        target.TakeDamage(damage);
        //Debug.Log("bang bang");
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }

}
