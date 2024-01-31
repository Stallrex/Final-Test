using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Enemy : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rb;
    public Animator animator;

    public GameObject AttackPoint;
    public GameObject AttackPoint1;
    public float x;

    bool Attack1 = false;
    bool Attack2 = false;

    private float attack_distance = 2f;
    private float distance;
    private float attack_mode;
    public bool inRange;

    public bool retreating = false;

    public GameObject target;

    public GameObject retreater;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy_Logic();
        Attack();
        
    }

    void Enemy_Logic(){
        distance = Vector2.Distance(transform.position, target.transform.position);

        if(distance > attack_distance){
            if(retreating == false){
                Move();
            }
            else{
                Retreat();
            }
            
        }
        else if(attack_distance >= distance){
            InitiateAttack();
        }

    }

    void Move(){
        retreating = false;
        Vector3 rotation = new Vector3(0, 180, 0);
        transform.eulerAngles = rotation;
        Vector2 targetPosition = new Vector2(target.transform.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        animator.SetFloat("Speed", Mathf.Abs(1));
    }
    void InitiateAttack(){

        var attacking = Random.Range(1, 3);
        if(attacking == 1){
            Attack1 = true;
        }
        if(attacking == 2){
            Attack2 = true;
        }
        


    }

    public void Retreat(){
        Vector3 rotation = new Vector3(0, 0, 0);
        transform.eulerAngles = rotation;
        Vector2 retreatPosition = new Vector2(retreater.transform.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, retreatPosition, speed * Time.deltaTime);
        animator.SetFloat("Speed", Mathf.Abs(1));
        Invoke("Move", 1);
    }









    void Attack(){
        var attack_sword1 = animator.GetCurrentAnimatorStateInfo(0).IsName("1attack_sword");
        var attack_sword2 = animator.GetCurrentAnimatorStateInfo(0).IsName("2attack_sword");
        
        if(Attack2 == true && attack_sword2 == false && attack_sword1 == false){
            animator.SetTrigger("Stab");
            AttackPoint1.SetActive(true);
            Invoke("Deactivate1", 0.1f);
            retreating = true;
            Attack2 = false;
            
            
        }
        if(Attack1 == true && attack_sword1 == false && attack_sword2 == false){
            animator.SetTrigger("Attack");
            Invoke("Deactivate", 0.1f);
            AttackPoint.SetActive(true);
            retreating = true;
            Attack1 = false;
            
    }
    }
    void Deactivate(){
        AttackPoint.SetActive(false);
    }
    void Deactivate1(){
        AttackPoint1.SetActive(false);
    }
}
