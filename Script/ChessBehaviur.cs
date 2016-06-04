using UnityEngine;
using System.Collections;

public class ChessBehaviur : MonoBehaviour {
		// Use this for initialization
		public bool isSelected = false;
		
		void Start () {
		}
		
		// Update is called once per frame
		void Update () {
		}
		
		void OnMouseDown(){
			if (isSelected) {
			ToNormalSize();
		} else {
			isSelected = true;
			this.transform.localScale = new Vector3(1.3f,1.3f,1.3f);
			}
		}
		public void ToNormalSize(){
			this.transform.localScale = new Vector3(1,1,1);
			isSelected = false;
		}
	}