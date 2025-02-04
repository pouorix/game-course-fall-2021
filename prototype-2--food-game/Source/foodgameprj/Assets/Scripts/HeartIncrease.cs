﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartIncrease : ComboInstanceController
{
    public EventSystemCustom eventSystem;
    // when player eats the combo item
    private void Start()
    {
    }

    public override void OnConsume(GameObject gameObject)
    {
        Debug.Log("Heart Increase ON CONSUME");
        Destroy(gameObject);
        eventSystem.OnHeartIncreaseCollected.Invoke();

        // you should fill this method!
    }
}