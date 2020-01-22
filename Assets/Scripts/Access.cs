using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Access : MonoBehaviour
{
    public GameObject player;
    public string URIDataBase;
    public Button boton;
    public GameObject input;
    public GameObject input1;
    public GameObject input2;
    private DBConnector _connector;
   
   

        public void guardar()
    {
        _connector = gameObject.AddComponent<DBConnector>();
        _connector.OpenDB("URI=file:Assets\\db\\" + URIDataBase);

        _connector.UpdateData(input.GetComponent<Text>().text, input1.GetComponent<Text>().text, input2.GetComponent<Text>().text, player.transform.position.x.ToString(), player.transform.position.y.ToString(), player.transform.position.z.ToString());
        _connector.CloseDB();
      
    }
    public void Start()
    {

        boton.onClick.AddListener(guardar);
      
    }


}