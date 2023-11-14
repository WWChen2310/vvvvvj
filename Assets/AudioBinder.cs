using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class AudioBinder : MonoBehaviour
{
    VisualEffect vfx;

    private float audioLevel;

    public float AudioLevel { get => audioLevel; set => audioLevel = value; }

    void OnEnable()
    {
        vfx = GetComponent<VisualEffect>();
    }

    [ExecuteInEditMode]
    void Update()
    {
        vfx.SetFloat("AudioLevel", AudioLevel);
    }
}
