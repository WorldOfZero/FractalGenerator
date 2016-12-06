using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(AnimationController))]
public class Publisher : MonoBehaviour {

    public string key;
    private IEnumerable<MaterialAnimator> animators;

    private AnimationController controller;

    public void Start()
    {
        controller = GetComponent<AnimationController>();
    }
    public void PublishChange(float value)
    {
        controller.PublishToAnimators(key, value);
    }
}
