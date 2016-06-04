using UnityEngine;
using System.Collections;

public class Ruler : MonoBehaviour {
	string[,] board = new string[4,4];
	// Use this for initialization
	void Start () {
		initBoard ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void initBoard(){
		for (int i = 0; i<4; i++) {
			for (int j=0; j<4; j++) {
				board [i,j] = "";
			}
		}
	}
}

public class redChess{
	public string part { get; set; }
	public Vector3 position{ get; set; }
//	public 
}