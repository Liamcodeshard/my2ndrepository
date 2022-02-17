using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public bool wantToPrintText = true;
    public bool wantsToMove = true;
    public string whatToPrint;
    public float movementAmount = 4.2f;
    public Transform checkWhichObjectToMove;
    public Color chooseYourColour;
    public Vector3 newPosition;
    public float speed = 10;

             // Start is called before the first frame update
    void Start()
    {
        #region
        if (wantToPrintText) {
            Debug.Log(checkWhichObjectToMove.localPosition);
        }   // this also works              .transform.position.x)
            // here i am gettting the console to tell me the vector data for the 1st fram
            // so i can later compare it when i move it to make sure that i have changed it 

        if (wantToPrintText){
            Debug.Log(wantToPrintText);
        }        //to see what happens when you print a bool and if i need to say == (turns out no)
        /*  if (wantsToMove){
            checkWhichObjectToMove.position += new Vector3(3, 0, 0); 
            } */
                //important to notice that when a vector class is called for the
                //first time then we must start it with the keyword: new - just do it
                //THIS CODE WORKS FINE but may not be super clear
                //next we will **use the constructor** 
     
        if (wantsToMove){
      /*      Vector3 newLocation = newPosition;  //a.k.a. using the constructor (the class? here vector)
            checkWhichObjectToMove.position += newLocation;   
            */ 

                //I have also chosen to allow the user to input the vector3 data
                // (newLocation) is a public class
                //this line of code does the same thing as above 
       /*
            newLocation.x = 0;
            newLocation.y = 0.5f;
            newLocation.z = 0.3f; 
            */
                // after we have called the vector and assigned it to a variable/withsomeinfo
                //we can change it and access it to modify it 
                //which we are doing for each axis here
                //use an f when using a float
    

            Vector3 newLocation = newPosition; //using the public variable for vector n
            checkWhichObjectToMove.position += Vector3.left;
        /*  checkWhichObjectToMove.Translate(Vector3.left + Vector3.forward * 4.2f);
        */
                //again doing the same thing but the vector is predesignated by unity 
                //it is a STATIC function that stays the same and makes it more readable
                // then we times it by SPEED (which should be a public function) here we used 4.2f instead.
        /*  checkWhichObjectToMove.Translate((Vector3.left + Vector3.forward) * movementAmount);
        */
                // same thing as the last line of code but using the public variable
                //we can also make this EVEN MORE SIMPLE by using the preset transform
                //the transform of the object that the script is attacthed to is static as:
                // 'transform' - important thing to note is the lack of a capital letter
                // we can write it as follows:
            transform.Translate((Vector3.left + Vector3.forward) * movementAmount);
                //here we have ignored the public variable checkWhichObject because of the fact
                // that unity has provided that (as mentioned above) as a functionable/usable variable
        }

        if (wantsToMove){
            Debug.Log(checkWhichObjectToMove.transform.position);
        }
        #endregion

    }
            //everything done in the Start() zone will only be done once at the start of the game
            // Update is called once per frame and so will happen continuously (everyframe!!)
            // and at a frequency that is relative to the Frames Per Second (FPS)
            // something to consider is that not all consoles are going to run at the same FPS
            // therefore we need to negate that. we can divide (use a magic number) but thats bad.
            // We use the static variable (this variable belongs to the class:Time) DeltaTime
            // This calculates the FPS by telling us how long ago the last frame was 
            //the amount of time that passed for the computer  to render the next frame.
    void Update()
    {
    /*  transform.Translate(Vector3.right * speed / 60);
    */      //this would work on MY laptop (with the FPS of 60)
            // but different FPS would create different speeds. 
            // so we use Time.deltatime to sense the FPS of whatever system we are running the program in.
          
    }
}
