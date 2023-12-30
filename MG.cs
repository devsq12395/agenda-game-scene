using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG : MonoBehaviour {
    public static MG I;
	public void Awake(){ I = this; }

    void Start() {
        

        ContArea.I.setup ();
    }

    void Update() {
        ContArea.I.render_roads ();
    }

    public void change_scene (string _scene){

    }
}
