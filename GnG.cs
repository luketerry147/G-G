using System;

/* Todo
 * - More in Character.cs
 * - More in RNG_Machine.cs
 * - Make a board
 * - Take input
 * - Add interaction between characters
 * 
 */
namespace GnG
{
    public class Driver
    {
        //Constructor
        public static Driver()
        {
            public static void Main(){
                rng = new RNG_Machine();
            }
        }
    }
    /*Global Data*/

    //Base Weapons
    //damage, isMartial, Finesse, Heavy, Light, Loading, needsAmmo, Range, Reach, Thrown, TwoHanded, Versatile, Material
    //Simple Melee
    Weapon club = new Weapon({1, 4}, false, false, false, true, false, false, 10, 5, false, false, false, "Wood");
    Weapon dagger = new Weapon({1, 4}, false, true, false, true, false, false, 60, 5, true, false, false, "Iron");
    Weapon greatclub = new Weapon({1, 8}, false, false, false, false, false, false, 5, 5, false, true, false, "Wood);
    Weapon handaxe = new Weapon({1, 6}, false, false, false, true, false, false, 60, 5, true, false, false, "Iron");
    

}
}
