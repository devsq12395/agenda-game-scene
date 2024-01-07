using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misc : MonoBehaviour {

    public static Misc I;
	public void Awake(){ I = this; }

    public string generate_id (){
        string _cL = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    
        int length = 8;
        System.Text.StringBuilder idBuilder = new System.Text.StringBuilder();

        for (int i = 0; i < length; i++) {
            int randomIndex = Random.Range (0, _cL.Length);
            char randomChar = _cL [randomIndex];
            idBuilder.Append (randomChar);
        }

        return idBuilder.ToString();
    }
}
