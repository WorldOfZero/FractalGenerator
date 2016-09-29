using UnityEngine;
using System.Collections;

public class Grower : MonoBehaviour {
    public void Generated(RecursiveBundle bundle)
    {
        this.transform.position += this.transform.up * this.transform.localScale.y;
    }
}
