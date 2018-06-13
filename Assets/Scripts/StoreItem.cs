using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    ClickPower,PerSecondIncrease
};

public class StoreItem : MonoBehaviour {
    [Tooltip("이 업그레이드의 가격이 얼만지")]
    public int Cost;

    public ItemType itemType;

    [Tooltip("구매한다면 얼마나 증가될 것인지")]
    public float IncreaseAmount;

    private int qty;

    public Text costText;
    public Text qtyText;

    private GameController controller;
    private Button button;

	// Use this for initialization
	void Start () {
        qty = 0;
        qtyText.text = qty.ToString();
        costText.text = "$" + Cost.ToString();

        button = transform.GetComponent<Button>();

        button.onClick.AddListener(this.ButtonClicked);

        controller = GameObject.FindObjectOfType<GameController>();
	}
	
	// Update is called once per frame
	private void Update () {
        button.interactable = (controller.Cash >= Cost);
	}

    public void ButtonClicked()
    {
        controller.Cash -= Cost;
        switch(itemType)
        {
            case ItemType.ClickPower:
                controller.CashPerClick += IncreaseAmount;
                break;
            case ItemType.PerSecondIncrease:
                controller.CashPerSecond += IncreaseAmount;
                break;
        }

        qty++;
        qtyText.text = qty.ToString();
    }
}
