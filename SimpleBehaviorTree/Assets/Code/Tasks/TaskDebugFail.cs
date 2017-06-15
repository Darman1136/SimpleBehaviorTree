using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskDebugFail : BTTask {
    public override bool Run() {
        Started();
        return Fail();
    }
}
