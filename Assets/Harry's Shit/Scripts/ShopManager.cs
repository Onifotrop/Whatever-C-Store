using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ShopManager : MonoBehaviour
{
    // Cost of money is the sum of all cost of objects
    public float costSum;
    public Player playerStats;
    
    #region public Item Cost and Count and buttons

    //the below is the cost of all items
        public float lighterCost;
        public float sprayCost;
        public float hammerCost;
        public float beerCost;
        public float scissorsCost;
        public float slurpyCost;
        public float bagCost;
        public float duckThighCost;
        public float magazineCost;
        public float penCost;
        public float flourCost;
        public float cokeCost;
        public float mentosCost;
        public float paperCost;
        public float cottonCost;
        public float nailsCost;
        //below is the item count
        public float lighterCount;
        public float sprayCount;
        public float hammerCount;
        public float beerCount;
        public float scissorsCount;
        public float slurpyCount;
        public float bagCount;
        public float duckThighCount;
        public float magazineCount;
        public float penCount;
        public float flourCount;
        public float cokeCount;
        public float mentosCount;
        public float paperCount;
        public float cottonCount;
        public float nailsCount;
        //buttons
        public TextMeshProUGUI lighterText;
        public TextMeshProUGUI sprayText;
        public TextMeshProUGUI hammerText;
        public TextMeshProUGUI beerText;
        public TextMeshProUGUI scissorsText;
        public TextMeshProUGUI slurpyText;
        public TextMeshProUGUI bagText;
        public TextMeshProUGUI duckThigh;
        public TextMeshProUGUI magazineText;
        public TextMeshProUGUI penText;
        public TextMeshProUGUI flourText;
        public TextMeshProUGUI cokeText;
        public TextMeshProUGUI mentosText;
        public TextMeshProUGUI paperText;
        public TextMeshProUGUI cottonText;
        public TextMeshProUGUI nailsText;
        
    #endregion

    public TextMeshProUGUI counterText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(costSum);
        counterText.text = "$" + costSum.ToString();
        lighterText.text = lighterCount.ToString();
        sprayText.text = sprayCount.ToString();
        hammerText.text = hammerCount.ToString();
        beerText.text = beerCount.ToString();
        scissorsText.text = scissorsCount.ToString();
        slurpyText.text = slurpyCount.ToString();
        bagText.text = bagCount.ToString();
        duckThigh.text = duckThighCount.ToString();
        magazineText.text = magazineCount.ToString();
        penText.text = penCount.ToString();
        flourText.text = flourCount.ToString();
        cokeText.text = cokeCount.ToString();
        mentosText.text = mentosCount.ToString();
        paperText.text = paperCount.ToString();
        cottonText.text = cottonCount.ToString();
        nailsText.text = nailsCount.ToString();

    }

    #region Buy button functions

    
 
    
    //Lighter
    public void buyLighter()
    {
        print("Buy Lighter");
        lighterCount += 1f;
        costSum += lighterCost;
    }
    
    public void deleteLighter()
    {
        print("Delete Lighter");
        if (lighterCount > 0)
        {
            lighterCount -= 1f;
            costSum -= lighterCost;
        }
    }
    //Spray
    public void buySpray()
    {
        print("Buy Spray");
        sprayCount += 1f;
        costSum += sprayCost;
    }
    
    public void deleteSpray()
    {
        print("Delete Spray");
        if (sprayCount > 0)
        {
            sprayCount -= 1f;
            costSum -= sprayCost;
        }
    }
    //Hammer
    public void buyHammer()
    {
        print("Buy Hammer");
        hammerCount += 1f;
        costSum += hammerCost;
    }
    public void deleteHammer()
    {
        print("Delete Hammer");
        if (hammerCount > 0)
        {
            hammerCount -= 1f;
            costSum -= hammerCost;
        }
    }
    //beer
    public void buyBeer()
    {
        print("Buy Beer");
        beerCount += 1f;
        costSum += beerCost;
    }
    
    public void deleteBeer()
    {
        print("Delete Beer");
        if (beerCount > 0)
        {
            beerCount -= 1f;
            costSum -= beerCost;
        }
    }
    //scissors
    public void buyScissors()
    {
        print("Buy Scissors");
        scissorsCount += 1f;
        costSum += scissorsCost;
    }
    
    public void deleteScissors()
    {
        print("Delete Scissors");
        if (scissorsCount > 0)
        {
            scissorsCount -= 1f;
            costSum -= scissorsCost;
        }
    }
    //slurpy
    public void buySlurpy()
    {
        print("Buy Slurpy");
        slurpyCount += 1f;
        costSum += slurpyCost;
    }
    public void deleteSlurpy()
    {
        print("Delete Slurpy");
        if (slurpyCount > 0)
        {
            slurpyCount -= 1f;
            costSum -= slurpyCost;
        }
    }
    //bag
    public void buyBag()
    {
        print("Buy Bag");
        bagCount += 1f;
        costSum += bagCost;
    }
    public void deleteBag()
    {
        print("Delete Bag");
        if (bagCount > 0)
        {
            bagCount -= 1f;
            costSum -= bagCost;
        }
    }
    //duck thigh
    public void buyDuckThigh()
    {
        print("Buy DuckThigh");
        duckThighCount += 1f;
        costSum += duckThighCost;
    }
    public void deleteDuckThigh()
    {
        print("Delete DuckThigh");
        if (duckThighCount > 0)
        {
            duckThighCount -= 1f;
            costSum -= duckThighCost;
        }
    }
    //magazine
    public void buyMagazine()
    {
        print("Buy Magazine");
        magazineCount += 1f;
        costSum += magazineCost;
    }
    public void deleteMagazine()
    {
        print("Delete Magazine");
        if (magazineCount > 0)
        {
            magazineCount -= 1f;
            costSum -= magazineCost;
        }
    }
    //pen
    public void buyPen()
    {
        print("Buy Pen");
        penCount += 1f;
        costSum += penCost;
    }
    public void deletePen()
    {
        print("Delete Pen");
        if (penCount > 0)
        {
            penCount -= 1f;
            costSum -= penCost;
        }
    }
    //flour
    public void buyFlour()
    {
        print("Buy Flour");
        flourCount += 1f;
        costSum += flourCost;
    }
    public void deleteFlour()
    {
        print("Delete Flour");
        if (flourCount > 0)
        {
            flourCount -= 1f;
            costSum -= flourCost;
        }
    }
    //coke
    public void buyCoke()
    {
        print("Buy Coke");
        cokeCount += 1f;
        costSum += cokeCost;
    }
    public void deleteCoke()
    {
        print("Delete Coke");
        if (cokeCount > 0)
        {
            cokeCount -= 1f;
            costSum -= cokeCost;
        }
    }
    //mentos
    public void buyMentos()
    {
        print("Buy Mentos");
        mentosCount += 1f;
        costSum += mentosCost;
    }
    public void deleteMentos()
    {
        print("Delete Mentos");
        if (mentosCount > 0)
        {
            mentosCount -= 1f;
            costSum -= mentosCost;
        }
    }
    //paper
    public void buyPaper()
    {
        print("Buy Paper");
        paperCount += 1f;
        costSum += paperCost;
    }
    public void deletePaper()
    {
        print("Delete Paper");
        if (paperCount > 0)
        {
            paperCount -= 1f;
            costSum -= paperCount;
        }
    }
    //cotton
    public void buyCotton()
    {
        print("Buy Cotton");
        cottonCount += 1f;
        costSum += cottonCost;
    }
    public void deleteCotton()
    {
        print("Delete Cotton");
        if (cottonCount > 0)
        {
            cottonCount -= 1f;
            costSum -= cottonCount;
        }
    }
    //nails
    public void buyNails()
    {
        print("Buy Nails");
        nailsCount += 1f;
        costSum += nailsCost;
    }
    public void deleteNails()
    {
        print("Delete Nails");
        if (nailsCount > 0)
        {
            nailsCount -= 1f;
            costSum -= nailsCount;
        }
    }
    
    //BUY THEM ALL

    public void buyAll()
    {
        if (playerStats.money >= costSum)
        {
            playerStats.money -= costSum;
            costSum = 0;
            lighterCount = 0;
            sprayCount = 0;
            hammerCount = 0;
            beerCount = 0;
            scissorsCount = 0;
            slurpyCount = 0;
            bagCount = 0;
            duckThighCount = 0;
            magazineCount = 0;
            penCount = 0;
            flourCount = 0;
            cokeCount = 0;
            mentosCount = 0;
            paperCount = 0;
            cottonCount = 0;
            nailsCount = 0;
        }
        else
        {
            print("Not enough money");
        }
    }

    #endregion
    
}
