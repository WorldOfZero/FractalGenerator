using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public enum MaterialTarget
{
    Zoom,
    ZoomX,
    ZoomY,
    PanX,
    PanY,
    SeedX,
    SeedY,
    Aspect
}

public class MaterialAnimator : MonoBehaviour {

    public string key;

    public Material modifiedMaterial;
    public MaterialTarget materialProperty;

    public void UpdateMaterial(float value)
    {
        var currentZoom = modifiedMaterial.GetVector("_Zoom");
        var currentPan = modifiedMaterial.GetVector("_Pan");
        var currentSeed = modifiedMaterial.GetVector("_Seed");
        switch (materialProperty)
        {
            case MaterialTarget.Zoom:
                modifiedMaterial.SetVector("_Zoom", new Vector4(value, value, value, value));
                break;
            case MaterialTarget.ZoomX:
                modifiedMaterial.SetVector("_Zoom", new Vector4(value, currentZoom.y, currentZoom.z, currentZoom.w));
                break;
            case MaterialTarget.ZoomY:
                modifiedMaterial.SetVector("_Zoom", new Vector4(currentZoom.x, value, currentZoom.z, currentZoom.w));
                break;
            case MaterialTarget.Aspect:
                modifiedMaterial.SetFloat("_Aspect", value);
                break;
            case MaterialTarget.PanX:
                modifiedMaterial.SetVector("_Pan", new Vector4(value, currentPan.y, currentPan.z, currentPan.w));
                break;
            case MaterialTarget.PanY:
                modifiedMaterial.SetVector("_Pan", new Vector4(currentPan.x, value, currentPan.z, currentPan.w));
                break;
            case MaterialTarget.SeedX:
                modifiedMaterial.SetVector("_Seed", new Vector4(value, currentSeed.y, currentSeed.z, currentSeed.w));
                break;
            case MaterialTarget.SeedY:
                modifiedMaterial.SetVector("_Seed", new Vector4(currentSeed.x, value, currentSeed.z, currentSeed.w));
                break;
        }
    }
}
