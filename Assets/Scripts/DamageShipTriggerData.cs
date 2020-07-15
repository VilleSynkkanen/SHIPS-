﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DamageShipTriggerData : ScriptableObject
{
    [SerializeField] float baseDamage;
    [SerializeField] float speedPower;
    [SerializeField] float moveSlowAmount;
    [SerializeField] float turningSlowAmount;
    [SerializeField] bool playDamageSound;

    public float BaseDamage { get => baseDamage; }
    public float SpeedPower { get => speedPower; }
    public float MoveSlowAmount { get => moveSlowAmount; }
    public float TurningSlowAmount { get => turningSlowAmount; }
    public bool PlayDamageSound { get => playDamageSound; }
}
