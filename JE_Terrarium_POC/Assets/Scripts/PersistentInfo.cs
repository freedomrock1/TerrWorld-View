using UnityEngine;
using System.Collections;

public class PersistentInfo : MonoBehaviour {

	public string city;
	public int buildingNum;
	public float latitude;
	public float longitude;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
