using UnityEngine;
using System.Collections;

public class Grower : MonoBehaviour {
    public void Generated(int index)
    {
        this.transform.position += this.transform.up * this.transform.localScale.y;
    }
}
