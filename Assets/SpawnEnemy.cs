using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownEnemy : MonoBehaviour
{
    public GameObject[] _enemys;
    public float _scrollSpeed = 10f;
    public Transform _enemysSpwanPoint;
    float _couter = 0f;
    // Start is called before the first frame update
    private void Start() 
    {
        SpownEnemi();
    }
    void SpownEnemi()
    {
        GameObject Enemy = Instantiate(_enemys[Random.Range(0, _enemys.Length)], _enemysSpwanPoint.position, Quaternion.identity);
        Enemy.transform.parent = transform;
        _couter = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (_couter <= 0)
        {
            SpownEnemi();
        }
        else 
        {
            _couter -= Time.deltaTime;
        }
        GameObject CurrentChild;
        for (int i = 0; i < transform.childCount; i++)
        {
            CurrentChild = transform.GetChild(i).gameObject;
            ScrollChallenges(CurrentChild);
        }
    }
    void ScrollChallenges(GameObject _current)
    {
        _current.transform.position += Vector3.left * _scrollSpeed * Time.deltaTime;
    }
}
