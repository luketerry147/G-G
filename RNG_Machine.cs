using System;
/*Todo
    Make roller remember all rolls made
*/
public class RNG_Machine
{
    Random rng = new Random();
	public RNG_Machine()
	{
	}
    public int rollXdY(int x, int y)
    {
        retvalue = 0;
        int currDiceVal;
        for (int i = 0; i < x; i++)
        {
            currDiceVal = rng.Next(y + 1);
            retvalue = retvalue + currDiceVal;
        }
        return retvalue;
    }
}
