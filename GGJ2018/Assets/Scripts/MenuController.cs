using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {


	public void NewGame(){
		Application.LoadLevel (1);
	}

	public void Credits(){

	}

	public void ExitGame(){
		Application.Quit ();
	}

}
