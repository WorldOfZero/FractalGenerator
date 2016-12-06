using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    private Dictionary<String, ICollection<MaterialAnimator>> animatorsMap;

    public void Start()
    {
        animatorsMap = new Dictionary<String, ICollection<MaterialAnimator>>();
        var animators = GetComponents<MaterialAnimator>();
        foreach (var animator in animators)
        {
            UpdateMaterialAnimator(String.Empty, animator.key, animator);
        }
    }

    public void UpdateMaterialAnimator(String oldKey, String newKey, MaterialAnimator animator)
    {
        if (animatorsMap.ContainsKey(oldKey))
        {
            var oldAnimatorList = animatorsMap[oldKey];
            oldAnimatorList.Remove(animator);
        }
        ICollection<MaterialAnimator> animatorList;
        if (!animatorsMap.ContainsKey(newKey))
        {
            animatorList = new LinkedList<MaterialAnimator>();
            animatorsMap.Add(newKey, animatorList);
        }
        else
        {
            animatorList = animatorsMap[newKey];
        }
        animatorList.Add(animator);
    }

    public void PublishToAnimators(String key, float value)
    {
        
        if (animatorsMap.ContainsKey(key))
        {
            var animators = animatorsMap[key];
            foreach (var animator in animators)
            {
                animator.UpdateMaterial(value);
            }
        }
    }
}
