using UnityEngine;

public interface IDamageable{
    public float Health{set; get;}

    public bool Targeteable {set; get;}
    public bool Invincible {set; get;}

    public void OnHit(float damage, Vector2 knockback);

    public void OnHit(float damage);

    public void OnObjetDestroyed();
}