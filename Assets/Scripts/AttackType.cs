using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackType : BeyBladeBase
{
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void FixedUpdate()
    {
        if (RotSpeed >= 1)
        {
            Rb.velocity = new Vector3(-Radius * Mathf.Sin(Time.time * RotSpeed), 0f, Radius * Mathf.Cos(Time.time * RotSpeed)) + (Target.transform.position - transform.position).normalized;
        }
        else Rb.velocity = Vector3.zero;
        base.FixedUpdate();
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }

    protected override void OnCollisionExit(Collision collision)
    {
        base.OnCollisionExit(collision);
    }
}
