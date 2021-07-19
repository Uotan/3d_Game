using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AninationPlayer : MonoBehaviour
{
    public bool _iscanberandom;
    public bool _srartAnima;
    public bool _ispair;
    public AnimationClip [] _Clips;
    public Animator _animator;
    public int _clipindex;

    //[AddComponentMenu("Для парных препятствий")]
    //[Header("Если объектов несколько")]

    [Tooltip("выбери парные объекты, первым должен быть главный объект")]
    public AninationPlayer[] _pairobjects;

    //List<int> numbers = new List<int>(){ 1, 2, 3, 45 };
    public List<int> _uniqueAnima;

    void Start()
    {
        if (_animator==null)
        {
            _animator = GetComponent<Animator>();
        }
        if (_iscanberandom==true)
        {
            _animator = GetComponent<Animator>();
            _animator.Play(_Clips[Random.Range(0,_Clips.Length)].name);
        }
        if (_ispair==true)
        {
            for (int i = 0; i < _pairobjects.Length; i++)
            {
                RandomizeAnima(i);
            }
        }
        if (_srartAnima == true)
        {
            _animator.Play(_Clips[_clipindex].name);
        }
    }
    void RandomizeAnima(int _numobj)
    {
        AhShitHereWeGoAgain:
        int _randidx = Random.Range(0, _Clips.Length);
        if (!_uniqueAnima.Contains(_randidx))
        {
            _uniqueAnima.Add(_randidx);
            _pairobjects[_numobj]._clipindex = _randidx;
            _pairobjects[_numobj]._ChildAnima();
        }
        else
        {
            goto AhShitHereWeGoAgain;
        }
    }
    void _ChildAnima()
    {
        _animator.Play(_Clips[_clipindex].name);
    }
}
