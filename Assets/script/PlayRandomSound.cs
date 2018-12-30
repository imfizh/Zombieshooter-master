using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour {

    public AudioSource _as;
    public AudioClip[] _asArray;
	void Start () {
        _as = GetComponent<AudioSource>();
        _as.clip = _asArray[Random.Range(0, _asArray.Length)];
        _as.PlayOneShot(_as.clip);
        _as.Play();
	}
	
	
}
