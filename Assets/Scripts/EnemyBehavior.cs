using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject target;
    private Rigidbody enemyRigidbody;
    public float speed;
    public float health;
    public ParticleSystem deathParticles;
    public bool isAttacking;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        if (target == null) { target = GameObject.FindWithTag("Player"); }
        enemyRigidbody = GetComponent<Rigidbody>();
        if (target)
        {
            health = 15;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack01") || animator.GetCurrentAnimatorStateInfo(0).IsName("Attack02")) 
        {
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }

        Vector3 lookDirection = (target.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(lookDirection * speed);
        transform.LookAt(target.transform);

        if (health <= 0)
        {
            Instantiate(deathParticles, transform.position, deathParticles.transform.rotation);
            Destroy(gameObject);
        }
    }

    /* public void OnTriggerEnter(Collider other)
     {
         if (isAttacking)
         {
             other.gameObject.GetComponent<EnemyBehavior>().health--;
             Debug.Log("Player has " + other.gameObject.GetComponent<EnemyBehavior>().health + " HP");
         }
     }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (isAttacking)
        {
          
        }
    }
}
