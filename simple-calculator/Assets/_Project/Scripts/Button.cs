using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Calculator _calculator;
	public string _value;

	private void OnMouseDown(){
		_calculator.SetInputValue (_value);
	}

	private void OnTriggerEnter(Collider collider){
		Transform transform = collider.GetComponent<Transform> ();

		if (transform.name == "bone3" && transform.parent.name == "index") {
			_calculator.SetInputValue (_value);
		}
	}
}
