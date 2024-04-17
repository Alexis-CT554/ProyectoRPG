using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : MonoBehaviour, IDamageable
{
    Animator animator;
    Rigidbody2D rb;
    bool isAlive = true;
    public float Health{
        set{
            if(value < _health){
                animator.SetTrigger("hit");
            }

            _health = value;

              if(_health <= 0){
                animator.SetBool("isAlive", false);
            }
        }
        get{
            return _health;
        }
    }
    public float _health = 3;

    public void Start(){
        animator = GetComponent<Animator>();
        animator.SetBool("isAlive", isAlive);

        rb = GetComponent<Rigidbody2D>();
    }

    public void OnHit(float damage, Vector2 knockback)
    {
        Health -= damage;
        rb.AddForce(knockback);
        Debug.Log("Force: " + knockback);
    }

    public void OnHit(float damage)
    {
        Health -= damage;
    }
}
