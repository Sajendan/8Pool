using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CoolDown 

{
    private float timer;
    [Range(0f,10f)]public float cooldown;

    public void updatetimer()
    {
        timer -= Time.deltaTime;
    }

    public bool TimerFinished()
    {
         return timer < 0;
    }

    public void ResetTimer()
    {
        timer = cooldown;
    }
}
