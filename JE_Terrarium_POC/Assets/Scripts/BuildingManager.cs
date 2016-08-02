using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BuildingManager : MonoBehaviour {

	public int buildingNum;

	GameObject info;
	PersistentInfo myInfo;

	// Use this for initialization
	void Start () {
		info = GameObject.Find ("Info");
		myInfo = info.GetComponent<PersistentInfo> ();
	}

	void OnMouseDown()
	{
		SceneManager.LoadScene ("Lan Vista Stub");
		myInfo.buildingNum = buildingNum;
	}
}
