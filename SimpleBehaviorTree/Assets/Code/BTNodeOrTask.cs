using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BTNodeOrTask : MonoBehaviour {
    public string btname;
    public BTNodeOrTask[] nodesAndTasks;

    public abstract bool Run();

    public void Started() {
        Debug.Log("Running     " + btname);
    }

    public bool Success() {
        Debug.Log("Succeeded " + btname);
        return true;
    }

    public bool Fail() {
        Debug.Log("Failed    " + btname);
        return false;
    }
}
