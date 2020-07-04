﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ShipDamage : MonoBehaviour
{
    [SerializeField] ShipSegment[] segments;
    [SerializeField] GameObject shipExplosion;
    [SerializeField] ShipType type;

    ShipData data;
    public float hp { get; private set; }

    float[] segmentHealth = new float[3];

    //front hp: speed
    //middle hp: control speed
    //rear hp: turning

    ShipMovement movement;
    ShipUI ui;
    PlayerInput input;

    public float[] SegmentHealth { get => segmentHealth; }
    public int MaxHp { get => data.MaxHp; }
    public ShipType Type { get => type; }
    public ShipMovement Movement { get => movement; }
    public ShipUI Ui { get => ui; }

    public event UnityAction<float, SegmentType> segmentDamage = delegate { };

    public static event UnityAction<GameObject> destroyed = delegate { };

    void Awake()
    {
        data = GameSettings.Instance.GetShipData(type);
        movement = GetComponent<ShipMovement>();
        ui = GetComponent<ShipUI>();
        input = GetComponent<PlayerInput>();
        segmentDamage += Movement.SegmentDamage;
        segmentDamage += Ui.UpdateHealthbars;
        hp = data.MaxHp;
        for (int i = 0; i < segmentHealth.Length; i++)
            SegmentHealth[i] = 1f;
    }

    public void ResetShipHealth()
    {
        hp = data.MaxHp;
        for (int i = 0; i < segmentHealth.Length; i++)
        {
            segments[i].ResetSegmentHealth();
            SegmentHealth[i] = 1f;
        }   
    }
    
    public void TakeDamage(float amount, SegmentType segment)
    {
        hp -= amount;
        int i = (int)segment;
        segmentHealth[i] = segments[i].hp / segments[i].MaxHp;
        segmentDamage(segmentHealth[i], segment);

        if(hp <= 0)
        {
            Destroy();
        }
    }

    void Destroy()
    {
        Instantiate(shipExplosion, transform.position, transform.rotation);
        gameObject.transform.position = new Vector3(1000,1000,-1000);
        destroyed(gameObject);
    }

    void OnDestroy()
    {
        segmentDamage -= Movement.SegmentDamage;
        segmentDamage -= Ui.UpdateHealthbars;
    }
}