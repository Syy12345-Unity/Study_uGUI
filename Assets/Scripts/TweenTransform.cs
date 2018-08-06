using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTransform : MonoBehaviour {
    [SerializeField]
    private TweenVector3 _tweenScale;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(_tweenScale.isUse)
        {
            transform.localScale = _tweenScale.Current(Time.realtimeSinceStartup);
        }
	}

    [Serializable]
    public class TweenVector3 {
        public bool isUse;

        public Vector3 startValue;
        public Vector3 endValue;
        public float duration = 1;
        public float speed = 1;
        public Vector3 Current(float time)
        {
            if(Mathf.Abs(duration) < Mathf.Epsilon)
            {
                return startValue;
            }
            return Vector3.Lerp(startValue,endValue,(time / duration) * speed  % 1);
        }

    }
}
