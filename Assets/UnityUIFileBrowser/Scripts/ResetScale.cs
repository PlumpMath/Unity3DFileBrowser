using UnityEngine;
using System.Collections;

using UnityEngine.UI;

/// <summary>
/// Reset object's scale
/// </summary>
[DisallowMultipleComponent]
public class ResetScale : MonoBehaviour {

	// Use this for initialization
    public void Start()
    {
        if (gameObject.GetComponent<RectTransform>() != null)
        {
            gameObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
    }
	
}
