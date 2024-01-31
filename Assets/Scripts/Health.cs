using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Health : MonoBehaviour
{
    public ParticleSystem blood;
    public UnityEvent onDamage;
    public UnityEvent onDeath;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void TakeDamage(int damage){
        health -= damage;
        onDamage.Invoke();
        Instantiate(blood, transform.position, transform.rotation);
        if(health <= 0){
            onDeath.Invoke();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
