using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> gameContainer = new GameContainer<string>();
        gameContainer.SetItem("Healing Potion");
        string description = gameContainer.GetItem();
        Debug.Log($"The description is {description}");

        string descriptionItem = GameUtils.DescribeItem(description);
        Debug.Log(descriptionItem);
        
        //? Test for me
        
        // GameContainer<int> gameTest = new GameContainer<int>();
        // gameTest.SetItem(101);
        // int test = gameTest.GetItem();
        // Debug.Log($"The description is {test}");

        // string testDescription = GameUtils.DescribeItem(test);
        // Debug.Log(testDescription);


    }

    
}
