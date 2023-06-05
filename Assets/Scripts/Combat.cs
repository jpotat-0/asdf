using RPGCharacterAnims;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using RPGCharacterAnims.Actions;
using RPGCharacterAnims.Extensions;
using RPGCharacterAnims.Lookups;

public class Combat : MonoBehaviour
{
    public @RPGInputs rpgInputs;
    public RPGCharacterController rpgCharacterController;
    public GameObject targetEnemy;
    public bool attacking;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if (!animator)
        {
            animator = GetComponentInChildren<Animator>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!targetEnemy)
        {
            targetEnemy = GameObject.FindWithTag("Enemy");
        }

        if (targetEnemy)
        {
            gameObject.GetComponent<RPGCharacterController>().target = targetEnemy.transform;
        }
    }
       

    
    private void LateUpdate()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (rpgCharacterController.isAttacking)
        {
            other.gameObject.GetComponent<EnemyBehavior>().health--;
            Debug.Log("Enemy has " + other.gameObject.GetComponent<EnemyBehavior>().health + " HP");
        }
    }
}
