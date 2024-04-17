using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public float damage = 1;
    public float knockbackForce = 100f;
    public float moveSpeed = 500f;

    public DetectionZone detectionZone;
    Rigidbody2D rb;

    DamageableCharacter damageableCharacter;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        damageableCharacter = GetComponent<DamageableCharacter>();
    }

    void FixedUpdate(){
        if(damageableCharacter.Targeteable && detectionZone.detectedObjs.Count > 0){

            Vector2 direction = (detectionZone.detectedObjs[0].transform.position - transform.position).normalized;

            rb.AddForce(direction * moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.collider.CompareTag("Player")) {  // Asegúrate de que solo afecte al jugador
            IDamageable damageable = col.collider.GetComponent<IDamageable>();

            if (damageable != null){
                Vector2 direction = (col.collider.transform.position - transform.position).normalized;
                Vector2 knockback = direction * knockbackForce;
                damageable.OnHit(damage, knockback);
            }
        }
    }
}
