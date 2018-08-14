using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {
    [SerializeField]
    Transform m_target;
	
	// Update is called once per frame
	void Update () {
		if(m_target == null)
        {
            return;
        }

        transform.LookAt(m_target);
	}
}
