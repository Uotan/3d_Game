using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AninationPlayer : MonoBehaviour
{
    public AnimationClip [] _Clips;
    Animator _animator;
    public int _clipindex;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play(_Clips[Random.Range(0,_Clips.Length)].name);
        //_animator.Play(_Clips[_clipindex].name);
    }
}
