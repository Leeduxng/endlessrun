using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlPlayer : MonoBehaviour
{
    public TextMeshPro _currentScore;
    public TextMeshPro _highScore;
    int _score = 0;
    public Animator _anim;
    public bool _jump;
    [SerializeField]  EndGame _end;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _jump = false;
        _highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && _jump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,7,0);
            _jump = true;
            _anim.SetBool("IsJump", true);
        }
        if(Input.GetKey(KeyCode.DownArrow) && _jump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,-1,0);
            _jump = true;
            _anim.SetBool("IsDown", true);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            _anim.SetBool("IsDown", false);
        }
        _score++;
        _currentScore.text = _score.ToString();
        if (_score > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag=="Finish")
        {
             _anim.SetBool("IsJump", false);
            _jump = false;
        }
        if(other.gameObject.tag=="Death")
        {
            _end.DeathMenu();
        }
    }
}
