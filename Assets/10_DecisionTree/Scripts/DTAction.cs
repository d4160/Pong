﻿public class DTAction : DecisionTreeNode
{
    public bool activated = false;

    public override DecisionTreeNode MakeDecision()
    {
        return this;
    }

    public virtual void LateUpdate()
    {
        if (!activated)
            return;
    }
}