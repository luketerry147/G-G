using System;

public class Weapon
{
    bool isMartial = false;
    //Special Weapon Properties
    bool Finesse = false;
    bool Heavy = false;
    bool Light = false;
    bool Loading = false;
    bool needsAmmo = false;
    int Ammo = 0;
    int Range = 0;
    int Reach = 0;
    bool Thrown = false;
    bool TwoHanded = false;
    bool Versatile = false;
    int[2] damage;
    String material;
	public Weapon(int[] dam, bool martial, bool fin, bool heav, bool lig, bool load, bool needAmmo, int rang, int  rea, bool thro, bool two, bool vers, String mat)
	{
        damage = dam;
        isMartial = martial;
        Finesse = fin;
        Heavy = heav;
        Light = lig;
        Loading = load;
        needsAmmo = needAmmo;
        Range = rang;
        Reach = rea;
        Thrown = thro;
        TwoHanded = two;
        Versatile = vers;
        material = mat;
	}

    public bool getWeapComplexity()
    {
        retvalue = false;
        if (isMartial)
        {
            retvalue = true;
        }else
        {
            retvalue = false;
        }
        return retvalue;
    }
    public int dealDamage()
    {
        return roll(damage[0], damage[1]);
    }
}
