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

        public News (){
            title = "";
            desc = "";
        }
    }

    public GameObject go;

    public TextMeshProUGUI t_title, t_desc;

    public List<News> newsList;

    public void setup (){
        newsList = new List<News> ();

        go.SetActive (true);

        

        go.SetActive (false);
    }

    public void show (ObjArea _a){
        t_area.text = _a.nameUI;
    }

    public void add_news (string _name, Dictionary<string, string> _details){
        News _news = DB_News.I.get_news_details (_name);
        newsList.Add (_news);
    }

    public void show_next_news (){
        
    }

    public void update_news (){
        News _news = newsList [0];
        t_title.text = _news.title;
        t_desc.text = _news.desc;
    }

    public void btn_next (){

    }
}
