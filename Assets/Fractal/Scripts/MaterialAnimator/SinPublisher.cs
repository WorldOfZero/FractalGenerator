using UnityEngine;
using System.Collections;

public class SinPublisher : MonoBehaviour {

    public float zeroValue = 1;
    public float amplitude = 1;
    public float timeScale = 0.25f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        SendMessage("UpdateMaterial", zeroValue + Mathf.Sin(Time.time * timeScale) * amplitude);
    }
}
