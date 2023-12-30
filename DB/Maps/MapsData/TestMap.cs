using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMap : MonoBehaviour {

    public static TestMap I;
	public void Awake(){ I = this; }

    public GameObject goMap;

    public DB_Maps.mapDetails get_map_details (DB_Maps.mapDetails _new){
        _new.size = new Vector2 (50, 50);

        ContMap.I.create_map_objs = create_map_objs;

        return _new;
    }

    public void create_map_objs (){
        
    }

}