﻿using UnityEngine;
using UnityEngine.Events;

public enum SegmentType { Front, Middle, Back }

public class ShipSegment : MonoBehaviour, ICollision
{
    [SerializeField] SegmentType type;
    ShipData data;
    [SerializeField] Rigidbody2D rb;    //rigidbody of ship
    [SerializeField] ShipDamage ship;
    int i;
    public float hp { get; private set; }
    public int MaxHp { get => data.SegmentHp[i]; }
    public Rigidbody2D Rb { get => rb; }
    public ShipDamage Ship { get => ship; }

    public event UnityAction<float, SegmentType> damageTaken = delegate { };

    void Awake()
    {
        data = GameSettings.Instance.GetShipData(Ship.Type);
        i = (int)type;
        hp = MaxHp;
        damageTaken += Ship.TakeDamage;
    }
    
    public void Collision(ProjectileCollision collider)
    {
        Vector2 velocity = collider.rb.velocity;
        Vector2 position = new Vector2(collider.transform.position.x, collider.transform.position.y);
        Rb.AddExplosionForce(collider.ExplosionForce, position);
        TakeDamage(collider.CalculateDamage(velocity));
    }

    public void TakeDamage(float amount)
    {
        hp -= amount;
        if (hp < 0)
            hp = 0;
        damageTaken(amount, type);
    }

    void OnDestroy()
    {
        damageTaken -= Ship.TakeDamage;
    }
}