﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObjectUITo3D : MonoBehaviour
{
    public Transform follow;
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
     //   var posInWorld = Camera.main.ScreenToWorldPoint();
        var posinUI = Camera.main.WorldToScreenPoint(follow.position);
        transform.position = posinUI;
    }
}
