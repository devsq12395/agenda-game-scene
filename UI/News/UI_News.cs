using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_News : MonoBehaviour {
    
    public static UI_News I;
	public void Awake(){ I = this; }

    public struct News {
        string title, desc;
    }

    public GameObject go;

    public TextMeshProUGUI t_title;

    public List<News> newsList;

    public void setup (){
        newsList = new List<News> ();

        go.SetActive (true);

        

        go.SetActive (false);
    }

    public void show (ObjArea _a){
        t_area.text = _a.nameUI;
    }
}
