using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageableCharacter : MonoBehaviour, IDamageable
{
    public GameObject healthText;
    public bool disableSimulation = false;
    public bool canTurnInvincible = false;
    public float invicibilityTime = 0.25f;
    Animator animator;
    Rigidbody2D rb;
    Collider2D physicsCollider;
    bool isAlive = true;

    private float invincibleTimeElapsed = 0f;
    public float Health{
        set{
            if(value < _health){
                animator.SetTrigger("hit");
                RectTransform textTransform = Instantiate(healthText).GetComponent<RectTransform>();
                textTransform.transform.position = Camera.main.WorldToScreenPoint(gameObject.transform.position);

                Canvas canvas = GameObject.FindObjectOfType<Canvas>();
                textTransform.SetParent(canvas.transform);
            }

            _health = value;

              if(_health <= 0){
                animator.SetBool("isAlive", false);
                Targeteable = false;
            }
        }
        get{
            return _health;
        }
    }

    public bool Targeteable { get {return _targeteable;}
    set {
        _targeteable = value;

        if(disableSimulation){
            rb.simulated = false;
        }


        physicsCollider.enabled = value;
    } }

    public bool Invincible { get{
        return _invincible;
    } set{
        _invincible = value;

        if (_invincible == true){
            invincibleTimeElapsed = 0f;
        }
        Debug.Log(Invincible);
    } }

    float _health = 3;

    bool _targeteable = true;

    public bool _invincible = false;

    

    public void Start(){
        animator = GetComponent<Animator>();
        animator.SetBool("isAlive", isAlive);

        rb = GetComponent<Rigidbody2D>();
        physicsCollider = GetComponent<Collider2D>();
    }

    public void OnHit(float damage, Vector2 knockback)
    {
        if(!Invincible){
            Health -= damage;
            rb.AddForce(knockback, ForceMode2D.Impulse);

            if(canTurnInvincible){
                Invincible = true;
            }
        }
    }

    public void OnHit(float damage)
    {
        if(!Invincible){
            Health -= damage;

            if(canTurnInvincible){
                Invincible = true;
            }
        }
       
    }

    public void OnObjetDestroyed()
    {
        Destroy(gameObject);
    }

    public void FixedUpdate(){
        if(Invincible){
            invincibleTimeElapsed += Time.deltaTime;

            if(invincibleTimeElapsed > invicibilityTime){
                Invincible = false;
            }
        }
    }
}
