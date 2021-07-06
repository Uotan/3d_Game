using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text _scoretext;
    public ball _playerscript;
    float _score;

    private void FixedUpdate() {
        //_score+= (Time.deltaTime * 2);
        _score+= Time.deltaTime;
        _scoretext.text = Mathf.Round(_score).ToString();
    }
}
