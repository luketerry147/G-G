using System;


/*Todo list
    - Revisit constructor after further progress has been made
    - make statuses a separate class
    - add equipment class (with subclasses armor, weapon, and other)
    - add race class
    
*/  
public class Character
{
    //Attributes
    int Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma;
    //Base Statistics
    String race, classname, name;
    int level;
    //Derived Statistics
    int Hitpoints, currHP, ArmorClass, InitBonus, Speed, size, profBonus;
    //Skills
    Skill Acrobatics = new Skill(false, "Dexterity", this);
    Skill AnimalHandling = new Skill(false, "Wisdom", this);
    Skill Arcana = new Skill(false, "Intelligence", this);
    Skill Athletics = new Skill(false, "Strength", this);
    Skill Decption = new Skill(false, "Charisma", this);
    Skill History = new Skill(false, "Intelligence", this);
    Skill Insight = new Skill(false, "Wisdom", this);
    Skill Intimidation = new Skill(false, "Charisma", this);
    Skill Investigation = new Skill(false, "Intelligence", this);
    Skill Medicine = new Skill(false, "Wisdom", this);
    Skill Nature = new Skill(false, "Intelligence", this);
    Skill Perception = new Skill(false, "Wisdom", this);
    Skill Performance = new Skill(false, "Charisma", this);
    Skill Persuasion = new Skill(false, "Charisma", this);
    Skill Religion = new Skill(false, "Intelligence", this);
    Skill SleightofHand = new Skill(false, "Dexterity", this);
    Skill Stealth = new Skill(false, "Dexterity", this);
    Skill Survival = new Skill(false, "Wisdom", this);

    //Type
        //Need separate class
    //Position
    int x, y, z;
    //Status
    bool blinded = false,
        charmed = false,
        deafened = false,
        frightened = false,
        grappled = false,
        incapacitated = false,
        invisible = false,
        paralyzed = false,
        petrified = false,
        poisoned = false,
        prone = false,
        restrained = false,
        stunned = false,
        unconscious = false;

    //Constructor
    public Character()
	{
        z = 0;
        x = 0;
        y = 0;
        Strength = 10;
        Dexterity = 10;
        Constitution = 10;
        Intelligence = 10;
        Wisdom = 10;
        Charisma = 10;
        race = "Human";
        size = medium;
        ArmorClass = 10;
    }

    //Getters
    public int getAttBonus(String attName)
    {
        int retvalue = 0;
        if(attName == "Strength") {retvalue = (Strength - 10) / 2}
        else if(attName == "Dexterity") {retvalue = (Dexterity - 10) / 2}
        else if(attName == "Constitution") {retvalue = (Constitution - 10) / 2 }
        else if(attName == "Intelligence") {retvalue = (Intelligence - 10) / 2}
        else if(attName == "Wisdom") {retvalue = (Wisdom - 10) / 2}
        else if(attName == "Charisma") {retvalue = (Charisma - 10) / 2}
        else {
            Console.WriteLine("Not an attribute name");
            retvalue = -6;
        }
        return retvalue;
    }

    public int getSkillBonus(Skill tobechecked)
    {
        retvalue = 0;
        if (tobechecked.getProf() == true)
        {
            retvalue = retvalue + profBonus;
        }
        retvalue = retvalue + getAttBonus(tobechecked.getAtt())
        return retvalue;
    }
}
