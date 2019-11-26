# CIS-466_final-project
Final project 

Hero Monster Battle Requirements
============
1. Create a Character class
    It should have properties:
        Name
        Health
        DamageMaximum
        AttackBonus

2. The Character class should have two methods:

    Attack() return an int - randomly determine the amount of damage this Character object inflicted.
        ((use the Random class))

    Defend(int damage) - deducts the damage from this Character's health

3.  In the Main Method create two instances of the Character class: 

        hero
        monster

        ... and set their attributes (to whatever you want)

4.  You will start by creating a new class named Dice.  The Dice class will have one property: int Sides, and method called Roll().  The Roll() method will use the Sides property as the maximum value used by the Random.Next() method.  The Roll() method will return the random number to the caller.  Hint: you cannot create a new instance of the Random class inside of the Roll() method otherwise you'll have that same problem we've fought before.  You must create a new instance of the Random class *outside* of the Roll() method.

5.  In the Main method, you will create a new instance of the Dice class and pass it as an input parameter to the Character class' Attack method.  The Attack method will set the Sides property, then will call the Dice class' Roll() method and use the return value as the return value of the Attack method as well.

6.  You will write the logic to check and see if the hero gets an attack bonus or if the monster gets an attack bonus.  In either case, you should perform the bonus attack and make the appropriate changes to the other character's health using the Defend method.

7.  You will create a while loop (a.k.a, the battle loop) and only break out of it once one character's health is less than zero.  Inside the while loop, the monster should attack the hero, then the hero should attack the monster.

8.  Create a helper method in the Default/Main  class to display the stats of each character.

9.  You will create a helper method in the Main class called displayResult() which accepts two input parameters, opponent1 and opponent2.  Depending on their health, determine the winner and print out a winning message using both their names.  If they both have health less than or equal to zero, then print out a message that they both died.
Programming Requirements:
Classes and Interfaces must be in separate files (not in the program.cs)
•	Must incorporate at least two of the three tenants of OOO
    Inheritance
    PolyMorphism
    Encapsulation
•	Must follow good OOO form
•	Must instantiate at least two classes (separate files)
•	Must use at least one interface
•	Must follow SOLID programming practices (and not violate any of the SOLID principles)
•	Must use Dependency Injection/Inversion
•	No method may be more than 6 lines of code (empty lines do not count)
•	Must be well commented but not over commented

//Bonus Points (only given if all main requirements are met)
•	add any graphic special effects
•	add addition features to make the battle more complex
•	use a design pattern
•	other bonus ideas will be entertained but must be approved in advance.


