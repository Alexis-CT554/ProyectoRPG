using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    public float swordDamage = 1f;
    public float knockbackForce = 15f;
    public Collider2D swordCollider;
    public Vector3 faceRight = new Vector3(0.116f, -0.054f, 0);
    public Vector3 faceLeft = new Vector3(-0.116f, -0.054f, 0);

    void Start(){
        if (swordCollider == null){
            Debug.LogWarning("Sword Collider not set");
        }  
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.CompareTag("Enemy")) {

            IDamageable damageableObject = collider.GetComponent<IDamageable>();

            if(damageableObject != null){
                //Vector3 parentPosition = gameObject.GetComponentInParent<Transform>().position;
                Vector3 parentPosition = transform.parent.position;

                //Vector2 direction = (Vector2) (collider.gameObject.transform.position - parentPosition).normalized;
                Vector2 direction = (collider.transform.position - parentPosition).normalized;

                Vector2 knockback = direction * knockbackForce;

                damageableObject.OnHit(swordDamage, knockback);
            } 
        } 
    }
    void IsFacingRight(bool isFacingRight) {
        if(isFacingRight) {
            transform.localPosition = faceRight;
        } else {
            transform.localPosition = faceLeft;
        }
    }

}
