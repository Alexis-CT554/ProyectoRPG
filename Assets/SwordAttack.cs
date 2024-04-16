using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour{

    Vector2 rightattackOffset;
    Collider2D swordCollider;

    private void Start() {
        swordCollider = GetComponent<Collider2D>();
        rightattackOffset = transform.position;
        swordCollider.enabled = false;
    }

    public void AttackRight(){
        print("Attack Right");
        swordCollider.enabled = true;
        transform.position = rightattackOffset;
    }

    public void AttackLeft(){
        print("Attack Left");
        swordCollider.enabled = true;
        transform.position = new Vector3(rightattackOffset.x * -1, rightattackOffset.y);
    }

    public void StopAttack(){
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){

        }
    }
}
