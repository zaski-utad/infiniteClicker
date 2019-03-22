using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	#region VARIABLES
	public TMPro.TextMeshProUGUI counter;	// Contador de galletas
	#endregion
	
	#region START
	private void Start()
	{
		currentNumber = 0;
		currentMultiplier = 1;
		currentBase = 1;
		//currentMultiplierAutocklick = 1;
		//currentUPS = 0;
	}
	#endregion
	
	#region UPDATE

	private void Update()
	{
		
	}

	#endregion
}
