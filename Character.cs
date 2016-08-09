using System;


/*Todo list
    - Revisit constructor after further progress has been made

    
*/  
public class Character
{
    int HP;
    int meleeSkill, defenseSkill, rangeSkill;
    int x, y, z;
    //int armor;                                        /* not sure if necessary */
    String name;
    Weapon mainhand, offhand;


    public Character()
    {

    }

    public int Attack(Character target)
    {
        int toHitRoll = 0;
        int damageDealt;
        bool success;
        if(mainhand == null) //No weapon in mainhand
        {
            //Fail to attack
                //Hit for small damage punch?
        }else //Try and hit with mainhand
        {
            toHitRoll = roll(meleeSkill, (meleeSkill + 100));
            if(toHitRoll > target.defenseSkill)
            {
                success = target.takeDamage(dealDamage(mainhand));
                if(!success)
                {
                    //break because we errored
                }
            }            
        }
        if(offhand != null)
        {
            //Hit with offhand
            toHitRoll = toHitRoll(meleeSkill, (meleeSkill + 100));
            if (toHitRoll > target.defenseSkill)
            {
                success = target.takeDamage(dealDamage(offhand));
                if (!success)
                {
                    //break because we errored
                }
                
            }
        }

    }

    //Has been dealt damage, called from Attack(Character)
    public bool takeDamage(int damageDealt)
    {
        bool success = true;
        HP = HP - damageDealt;
        if(HP <= 0)
        {
            die();
        }
        return success;
    }

    //Remove from turn order
    public void die()
    {
        return;
    }
}
