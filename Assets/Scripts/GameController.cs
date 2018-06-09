using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    private float _Cash;
    public Text CashText;
    public float Cash
    {
        get { return _Cash; }
        set
        {
            _Cash = value;
            CashText.text = "You have : $" + _Cash;
            Cash.ToString("0.00");
        }
    }

    private float _CashPerSecond;
    public Text RateText;
    public float CashPerSecond
    {
        get { return _CashPerSecond; }
        set
        {
            _CashPerSecond = value;
            RateText.text = "per second: " + _CashPerSecond.ToString("0.0");
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
