using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text Name;
    public Text Hp;
    
    // Start is called before the first frame update
    void Start()
    {
        Name.text = Menu.CurrentName.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        Hp.text = "♥x " +  GameController.Instance.Player.CurrentHealth.ToString();
    }
}
