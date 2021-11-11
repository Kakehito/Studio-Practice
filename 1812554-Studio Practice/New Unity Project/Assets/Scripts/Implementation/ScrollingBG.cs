using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScrollingBG : MonoBehaviour
{

    private RawImage _img;
    public float _Y;
    public float _X;

    private void Start()
    {
        _img = GetComponent<RawImage>();
    }

    private void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_X, _Y) * Time.deltaTime, _img.uvRect.size);
    }



}
