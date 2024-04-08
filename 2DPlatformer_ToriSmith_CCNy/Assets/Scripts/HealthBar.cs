using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthBar : MonoBehaviour
{
    //IN CLASS CCNY MW

    //GLOBAL VARIABLES
    public Slider slider; //declare & set slider UI variable in the inspector

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //NOTE: these voids are public so we can call them from other scripts
    //Change the Health Slider
    public void SetHealth(int health) //declare a void & feed it a variable (in this case an integer) 
    {
        slider.value = health; //change the value parameter of the slider to equal the value of health
    }
    //set the max value of the health bar
    public void SetMaxHealth(int health) //declare a void & feed it a variable (in this case an integer) 
    {
        slider.maxValue = health; //set health to the max value of our slider component
        slider.value = health; //set the value of our slider comonent to health
    }
}

//HEALTH BAR UI INSTRUCTIONS
//1.Downloads
//a.Download the "Bar" & "Heart" Sprites and put them into your project. They're in my GitHub Repo and on Blackboard in the "Assets" Content Folder.
//2. Canvas & Object Setup
//		a. Add a Canvas. Add an Image Object to the canvas.
//		b. Add the bar sprite to the Image. Click "set native size" in the inspector to prevent any weird stretching. Rename the Image Object as "Border".
//		c. Create an empty game object on the canvas and rename it "Health Bar". Make it the same size as your "Border" image using the Rect tool.
//        d.Parent the Border Image to the Health Bar empty object. This will act as a "Parent Object" to keep all your other sprites organized and grouped together. 
//		e. Add an Image as a child to the Health Bar. Name it "Fill". Order it ABOVE your Border so it shows underneath.
//		f. Open "Anchor Presets" in the Fill's Rect Transform. Hold down alt/opt and select the bottom right. This will set the scale and anchor points to that of our health bar. This will change the scale of our fill if we change the scale of the health bar. 
//		g. We can now scale just the Fill to create demo of our health values going up or down. Change the color to whatever you please (mine is Red)
//	3.Slider Component
//       a.Add a Slider Component to your Health Bar.Make it "non-interactable", change the transition & navigation to "none" to ensure it's a static object we can only alter through code.
//       b.Drag your Fill object into the Fill Rect of the Slider. Now we can adjust the slider. DEMO THIS. 
//	4. Border Fix
//       a.Select your Border so we can resize our Health Bar and change the Border's size as well. Change the Anchor Preset to the bottom right object. DO NOT HOLD ALT/OPT FOR THIS ONE. This will only set the anchors, not adjusting the scale of that UI object.
//	5. Add the Heart (make it pretty)
//        a.Add an Image as a child to the Health bar. Drag in the heart sprite and click set native size. Set the Anchor Point to Middle Left so we can anchor it to the left hand size.
//	6. Slide Finish
//In the Slider component, change the Max Value to whatever you want your max health to be. Check Whole numbers to use ints instead of floats (I'm going to use 20)