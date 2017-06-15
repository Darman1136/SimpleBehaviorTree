using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTRoot : MonoBehaviour {

    public BTNodeOrTask node;

    private bool once = true;
    void Update() {
        if (once) {
            Debug.Log("Running     Root");
            if (node)
                node.Run();
            once = false;
        }
    }
}
