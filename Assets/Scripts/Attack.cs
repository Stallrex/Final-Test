using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public ParticleSystem parry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject != this.transform.parent.gameObject && collision.gameObject != collision.gameObject.CompareTag("Wall") && collision.gameObject != collision.gameObject.CompareTag("Attack1") && collision.gameObject != collision.gameObject.CompareTag("Attack2"))
        {


        Health health = collision.gameObject.GetComponent<Health>();
        var damage = 10;
        health.TakeDamage(damage);
        

        }
        if (collision.gameObject.CompareTag("Attack1"))
        {   
            Instantiate(parry, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Attack2"))
        {
            Instantiate(parry, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }

        
    }
        

}
