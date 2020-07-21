﻿using System.Collections;
using UnityEngine;

public class MineShooter : InstantShooter
{
    MineShooterData mineData;
    [SerializeField] bool giveFriendlyTag;
    
    void Start()
    {
        mineData = (MineShooterData)Data;
    }

    public override void Shoot()
    {
        foreach (Transform location in ShotLocations)
        {
            GameObject mine = Instantiate(Projectile, location.position, location.rotation);
            mine.transform.SetProjectileParent();
            mine.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * Data.ShotForce);
            StartCoroutine(ActivateCollider(mine.GetComponent<Collider2D>()));
            location.gameObject.GetComponent<AudioSource>().Play();
            if (giveFriendlyTag)
                mine.tag = tag;

            if (Data.LimitedAmmo)
            {
                ExpendAmmo();
            }
        }

        TriggerShotEvent();
    }

    IEnumerator ActivateCollider(Collider2D collider)
    {
        yield return new WaitForSeconds(mineData.ActivationDelay);
        collider.enabled = true;
    }
}
