///  Note,looking through my scripts you will find two types of notes, the ones right over lines of code and the ones under.
///The ones right over are ones that describe why the code line(s) are there and what they do, and what they are connected to. 
///- So all the useful stuff. Then the ones below the line(s) of code, those are additional notes, summaries of things tried, 
///lessons learned and why that specific line of code is written like that instead of xyz. 
///In those additional notes there might show up a Reminder: [something], they are short-hand for something, which we can read about in the Reminder script. 




// There is only one purpose for this script. 

//That is to explain my short-hand reminders, normally I will just type these all the way out inside my scripts,
//at every script to remember to avoid past mistakes.
//Which is easier because there's way I can just hover over my short-hand and it shows the explanation.

//But it does have the consequence of it becoming a wall of note text, in every script, which can be very overwhelming so to combat this,
//and be more time efficient, this script exists.  

// is sorted in Alphabetical order.

//-------------------------------------------------------------------------------------------------------------------------------------------------


//AmericanZ | American spelling; if this(whatever line of code) does not work, check your spelling, this is an engine running on American English, chances are high that you wrote the word in the British Standard, instead.


//Horizontal / Vertical AD / WS | When writing a movement script, and do the Input.GetAxisRaw(""), and the "" holds either Horizontal / Vertical, firstly: AmericanZ, secondly: "Horizontal" ref. to the keyboard specifically, what's Horizontal on the keyboard, a and d.  "Vertical" ref. to the keyboard specifically, what's Vertical on the keyboard, w and s. Like how the WSAD look if you look at them on the keyboard.


//Up | needs to be in update to function properly, if in fixed updates, there will be missing data. 

//this be empty | it needs to be filled with the component in question. AKA get the component in Start(). [name&address] = GetComponent<[placeholder]>(); is class need (). eg. rb = GetComponent<Rigidbody>(); 



//transformation.forward = z | Remember to build scene in that direction, so z is forward, else you can be confused when making moveDirection and PlayerMovements, it works but it looks like it does not. So you might think it does not. //Spent 4 hours~ once, because of this.





