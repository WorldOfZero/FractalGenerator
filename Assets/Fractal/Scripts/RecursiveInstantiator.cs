using UnityEngine;
using System.Collections;

public class RecursiveInstantiator : MonoBehaviour {

    public int recurse = 5;
    public int splitNumber = 2;
    public Vector3 pivotPosition;

	// Use this for initialization
	void Start () {
        recurse -= 1;

	    for (int i = 0; i < splitNumber; ++i)
	    {
	        if (recurse > 0)
	        {
	            var copy = Instantiate(gameObject);
	            var recursive = copy.GetComponent<RecursiveInstantiator>();
	            recursive.SendMessage("Generated", new RecursiveBundle() { Index = i, Parent = this });
	        }
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
