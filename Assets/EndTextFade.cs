using UnityEngine;
using System.Collections;

public class EndTextFade : MonoBehaviour {
    public Color colorStart = Color.red;
    public Color colorEnd = Color.green;
    public float duration = 1.0F;
	
	
    void Update() {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        GetComponent<Renderer>().material.color = Color.Lerp(colorStart, colorEnd, lerp);
    }
}