using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjArea : MonoBehaviour {  

    [Header("------ UNITY EDITOR EDITABLE PARTS ------")]
    public string name;
    public List<string> optBad, optIntimidated, optNeutral, optFriends, optAllies;

    [Header("------ NON-EDITABLE PARTS ------")]
    public GameObject go;
    public string id;
    public RectTransform rect;
    public Dictionary <string, List<string>> options;
    public List<string> connections;
    public Dictionary <string, string> relation;
    public Dictionary <string, int> relationNumVal;

    public void setup (){
        go = gameObject;
        Debug.Log (go.transform.position);
        options = new Dictionary <string, List<string>> ();
        relation = new Dictionary <string, string> ();
        id = Misc.I.generate_id ();

        options.Add ("bad", new List<string>(optBad));
        options.Add ("intimidated", new List<string>(optIntimidated));
        options.Add ("neutral", new List<string>(optNeutral));
        options.Add ("friends", new List<string>(optFriends));
        options.Add ("allies", new List<string>(optAllies));
    }

    
}