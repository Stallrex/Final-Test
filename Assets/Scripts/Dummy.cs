using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Hit(){

    animator.SetTrigger("Hit");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
