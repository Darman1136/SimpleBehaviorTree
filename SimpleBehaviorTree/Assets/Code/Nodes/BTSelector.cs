using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Executes its children from top to bottom and will stop executing when one of its children succeeds.
 * If one child succeeds, the Selector succeeds. If all children fail, the Selector fails. 
 */
public class BTSelector : BTNode {
    public override bool Run() {
        Started();
        if (nodesAndTasks.Length == 0)
            return Success();

        foreach (BTNodeOrTask nodeOrTask in nodesAndTasks)
            if (nodeOrTask && nodeOrTask.Run())
                return Success();

        return Fail();
    }
}
