using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    [SerializeField] private Text mineLvl1Amount;
    [SerializeField] private Text mineLvl1Cost;
    [SerializeField] private Text mineLvl2Amount;
    [SerializeField] private Text mineLvl2Cost;
    [SerializeField] private Text mineLvl3Amount;
    [SerializeField] private Text mineLvl3Cost;
    [SerializeField] private Text mineLvl4Amount;
    [SerializeField] private Text mineLvl4Cost;
    [SerializeField] private Text mineLvl5Amount;
    [SerializeField] private Text mineLvl5Cost;
    [SerializeField] private Text mineLvl6Amount;
    [SerializeField] private Text mineLvl6Cost;
    [SerializeField] private Text mineLvl7Amount;
    [SerializeField] private Text mineLvl7Cost;
    [SerializeField] private GameObject upgradesBar;

    private Animator animator;


    private float currentPoints;
    // Start is called before the first frame update
    void Start()
    {
        currentPoints = 0;
        Mine.OnBought += UpdateMineInfo;


        animator = upgradesBar.GetComponent<Animator>();
    }

    private void OnDestroy()
    {
        Mine.OnBought -= UpdateMineInfo;

    }
    

    private void UpdateMineInfo(float points,ref int amount, int lvl,ref float cost, float costMultiplier)
    {
        float calculatedCost = CalculateCost(cost,costMultiplier);
        switch (lvl)
        {
            case 1:
                mineLvl1Amount.text = amount.ToString();
                mineLvl1Cost.text = NormalizePointsText(calculatedCost);
                break;
            case 2:
                mineLvl2Amount.text = amount.ToString();
                mineLvl2Cost.text = NormalizePointsText(calculatedCost);
                break;
            case 3:
                mineLvl3Amount.text = amount.ToString();
                mineLvl3Cost.text = NormalizePointsText(calculatedCost);
                break;
            case 4:
                mineLvl4Amount.text = amount.ToString();
                mineLvl4Cost.text = NormalizePointsText(calculatedCost);
                break;
            case 5:
                mineLvl5Amount.text = amount.ToString();
                mineLvl5Cost.text = NormalizePointsText(calculatedCost);
                break;
            case 6:
                mineLvl6Amount.text = amount.ToString();
                mineLvl6Cost.text = NormalizePointsText(calculatedCost);
                break;
            case 7:
                mineLvl7Amount.text = amount.ToString();
                mineLvl7Cost.text = NormalizePointsText(calculatedCost);
                break;
        }
        
    }

    private string NormalizePointsText(float calculatedCost)
    {
        string normalizedCostText = calculatedCost.ToString();
        
        if (calculatedCost >= 1000)
        {
            normalizedCostText = calculatedCost / 1000 + "k";
        } 
        if (calculatedCost >= 1000000)
        {
            normalizedCostText = Mathf.Floor(calculatedCost / 1000)/1000 + "M";
        }
        if (calculatedCost >= 1000000000)
        {
            normalizedCostText = Mathf.Floor(calculatedCost / 1000000)/1000 + "B";
        }

        return normalizedCostText;
    }

    private float CalculateCost(float cost, float costMultiplier)
    {
        return Mathf.Floor(cost * costMultiplier);
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePointsText();
    }
    
    public void OpenUpgradesMenu()
    {
        if (animator != null)
        {
            bool isOpened = animator.GetBool("isOpened");
            
            animator.SetBool("isOpened", !isOpened);
        }
    }


    public void UpdatePoints(float currentPoints)
    {
        this.currentPoints = currentPoints;
    }

    private void UpdatePointsText()
    {
        pointsText.text = "Plants: " + NormalizePointsText(Mathf.Floor(currentPoints));
    }
}
