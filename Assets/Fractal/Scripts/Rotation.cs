using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    public float angle = 30;

    public void Generated(int index)
    {
        this.transform.rotation *= Quaternion.Euler(angle * ((index * 2) - 1), 0, 0);
    }
}
