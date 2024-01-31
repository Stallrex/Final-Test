using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Main_Player : MonoBehaviour
{

    public float speed = 3;
    Rigidbody2D rb;
    public Animator animator;

    public GameObject AttackPoint;
    public GameObject AttackPoint1;

    public ParticleSystem Dust;
    public float x;
    private bool CanMove = true;


    // Start is called before the first frame update
    void Start()
    {
        Dust.Play();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            Attack(); 
            if(CanMove == true){
                Move();
            }
            
    }

    void Move(){
        x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(x));
        var Dust_emission = Dust.emission;

        if(x != 0){
            Dust_emission.enabled = true;
        }
        else{
        Dust_emission.enabled = false;
        }
        
        if(x < 0){
            Vector3 rotation = new Vector3(0, 180, 0);
            transform.eulerAngles = rotation;
        }
        if(x > 0){
            Vector3 rotation = new Vector3(0, 0, 0);
            transform.eulerAngles = rotation;
        }

    } 
    void Attack(){
        var attack_sword1 = animator.GetCurrentAnimatorStateInfo(0).IsName("1attack_sword");
        var attack_sword2 = animator.GetCurrentAnimatorStateInfo(0).IsName("2attack_sword");
        
        if(Input.GetKeyDown(KeyCode.Mouse0) && attack_sword2 == false && attack_sword1 == false){
            animator.SetTrigger("Stab");
            AttackPoint1.SetActive(true);
            Invoke("Deactivate1", 0.1f);
        }
        if(Input.GetKeyDown(KeyCode.Mouse1) && attack_sword1 == false && attack_sword2 == false){
            animator.SetTrigger("Attack");
            Invoke("Deactivate", 0.1f);
            AttackPoint.SetActive(true);

        }


        
    }
    void DisableMovement(){
        CanMove = false;
        x = 0;
        animator.SetFloat("Speed", Mathf.Abs(x));
        rb.velocity = new Vector2(0, 0);
        
    }
    void EnableMovement(){
        CanMove = true;
    }

    void Deactivate(){
        AttackPoint.SetActive(false);
    }
    void Deactivate1(){
        AttackPoint1.SetActive(false);
    }
}
