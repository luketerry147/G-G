using System;

private class Skill
{
    bool proficient;
    String relevantAttribute;
	public Skill(bool prof, String relAtt)
	{
        proficient = prof;
        relevant_attribute = relAtt;
	}

    public bool getProf() { return proficient; }
    public String getAtt() { return relevantAttribute; }
}
