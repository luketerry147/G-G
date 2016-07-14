using System;

public class Profession
{
    //Attributes
    String name;
    int hitDie;
    Skill[] skills;
    int level;
	public Profession(String iscalled, Skill[] isprofat, int hashitdie)
	{
        name = iscalled;
        int numskills = isprofat.Length;
        skills = new Skill[numskills];
        for(int i = 0; i < numskills; i++)
        {
            skills[i] = isprofat[i];
        }
	}

    public void setLevel(int newlevel)
    {
        if(newlevel > 0)
        {
            this.level = newlevel;
        }        
    }

    public Skill[] getSkillProfs()
    {
        return skills;
    }

    public int getHitDie()
    {
        return hitDie;
    }
}
