using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
public class HealthSystem : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public GameObject player;

    public void TakeDamage(int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            onDie.Invoke();
            if(player == null)
            {
                Destroy(gameObject); 
            }
            
        }
        if (player !=null)
        {
            InvokeRepeating("regen", 4, 50);

        }
    }
    public void regen()
    {
        if (health < 4)
        {
            health += 1;
            onDamaged.Invoke(health);
        }
        else
        {
            CancelInvoke("regen");
        }
        
    }
}

