using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	GameObject selected;
	GameObject blueChess;
	ChessBehaviur chessBehaviur;
	// Use this for initialization
	void Start () {
		selected = GameObject.FindGameObjectWithTag ("selected");
		blueChess = GameObject.FindGameObjectWithTag ("blueChess");
		chessBehaviur = blueChess.GetComponent<ChessBehaviur> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		selected.SetActive (true);
		selected.transform.position = this.transform.position;
	}

	void OnMouseExit(){
		selected.SetActive (false);
	}

	void OnMouseDown(){
		if (chessBehaviur.isSelected) {
			blueChess.transform.position = this.transform.position;
			chessBehaviur.ToNormalSize();
		} else {
			
		}
	}
}
