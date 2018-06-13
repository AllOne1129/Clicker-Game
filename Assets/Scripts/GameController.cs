using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    private float _Cash;
    public float Cash
    {
        get { return _Cash; }
        set
        {
            _Cash = value;
            CashText.text = "You have : $" + _Cash.ToString("0.00");
        }
    }

    private float _CashPerSecond;
    public float CashPerSecond
    {
        get { return _CashPerSecond; }
        set
        {
            _CashPerSecond = value;
            RateText.text = "per second : " + _CashPerSecond.ToString("0.00");
        }
    }

    [Tooltip("버튼을 누를 때마다 플레이어가 벌어들이는 돈.")]
    public float CashPerClick = 1;

    [Header("Object References")]
    public Text CashText;
    public Text RateText;
	// Use this for initialization
	void Start () {
        Cash = 0;
        CashPerSecond = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Cash += CashPerSecond * Time.deltaTime;
	}

    public void ClickedButton()
    {
        Cash += CashPerClick;
    }
}
