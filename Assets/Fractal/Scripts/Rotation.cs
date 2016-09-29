using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    public float angle = 30;

    public void Generated(RecursiveBundle bundle)
    {
        this.transform.rotation *= Quaternion.Euler(angle * ((bundle.Index * 2) - 1), 0, 0);
    }
}
