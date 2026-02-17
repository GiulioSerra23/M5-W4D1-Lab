
using UnityEngine;

public class AnimationParamHandler : MonoBehaviour
{
    [Header ("Param Names")]
    [SerializeField] private string _forwardName = "forward";

    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    public void SetForward(float speed)
    {
        _anim.SetFloat(_forwardName, speed);
    }
}
