using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskDebugSuccess : BTTask {
    public override bool Run() {
        Started();
        return Success();
    }
}
