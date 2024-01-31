using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject dummy;
    public GameObject enemy;

    public GameObject Player;
    private int Entity_ID;

    // Start is called before the first frame update
    void Start()
    {

        var Playerposition = new Vector2(-9, -2);

        Instantiate(Player, Playerposition, transform.rotation);

        int Entity_ID = Enemy_ID.Enemy;

        if(Entity_ID == 1){

            Instantiate(dummy, transform.position, transform.rotation);
        }
        if(Entity_ID == 2){
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
