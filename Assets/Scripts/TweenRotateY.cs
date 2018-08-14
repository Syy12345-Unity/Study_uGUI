using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenRotateY : MonoBehaviour {
    [SerializeField]
    float duration = 10;
	
	// Update is called once per frame
	void Update () {
		var angle = transform.localRotation.eulerAngles;
        angle.y += 360/duration * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(angle);
	}
}
