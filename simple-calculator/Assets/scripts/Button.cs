using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Calculator _calculator;
	public string _value;

	private void OnMouseDown(){
		_calculator.SetInputValue (_value);
	}
}
