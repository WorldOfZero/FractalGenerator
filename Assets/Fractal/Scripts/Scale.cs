using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour {
    public float scalar = 0.5f;

    public void Generated(RecursiveBundle bundle)
    {
        this.transform.localScale *= scalar;
    }
}
