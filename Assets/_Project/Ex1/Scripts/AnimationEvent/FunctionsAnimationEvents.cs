
using UnityEngine;

public class FunctionsAnimationEvents : MonoBehaviour
{
    private SurfaceImpactAudioController _surfaceAudioController;

    private void Awake()
    {
        _surfaceAudioController = GetComponentInParent<SurfaceImpactAudioController>();
    }

    public void OnFootStep()
    {
        _surfaceAudioController.OnFootStep();
    }
}
