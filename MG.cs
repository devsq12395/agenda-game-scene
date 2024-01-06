using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG : MonoBehaviour {
    public static MG I;
	public void Awake(){ I = this; }

    void Start() {
        

        ContArea.I.setup ();
        ContPlayers.I.setup ();
        ContChars.I.setup ();
    }

    void Update() {
        
    }

    public void change_scene (string _scene){

    }
}
