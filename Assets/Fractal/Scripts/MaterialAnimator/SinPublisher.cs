using UnityEngine;
using System.Collections;

public class SinPublisher : Publisher
{

    public float zeroValue = 1;
    public float amplitude = 1;
    public float timeScale = 0.25f;

	// Use this for initialization
	void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
        PublishChange(zeroValue + Mathf.Sin(Time.time * timeScale) * amplitude);
    }
}
