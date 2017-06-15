using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Executes its children from top to bottom and will stop executing when one of its children fails. 
 * If a child fails, then the Sequencer fails. If all children succeed, then the Sequencer succeeds. 
 */
public class BTSequenzer : BTNode {
    public override bool Run() {
        Started();
        foreach (BTNodeOrTask nodeOrTask in nodesAndTasks)
            if (!nodeOrTask || !nodeOrTask.Run())
                return Fail();

        return Success();
    }
}
