using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Flee : AI.DecisionTree.TreeAction
{
    public Action OnFlee;

    public override void NodeFunction()
    {
        OnFlee?.Invoke();
    }
}
