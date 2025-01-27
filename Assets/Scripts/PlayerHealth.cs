using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    //create a public method which reduces hitpoints by the amount of damage
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
           //Debug.Log("You dead");
           GetComponent<DeathHandler>().HanleDeath();
        }
    }
}
