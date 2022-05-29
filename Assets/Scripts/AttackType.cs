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
        if (RotSpeed > 0)
        {
            //円を描いて移動する
            Vector3 circle = new Vector3(-Radius * Mathf.Sin(Time.time * Speed), 0f, Radius * Mathf.Cos(Time.time * Speed));
            Vector3 goTarget = Target.transform.position - transform.position;
            Rb.velocity = circle + goTarget.normalized ;
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
