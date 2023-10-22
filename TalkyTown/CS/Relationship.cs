using System;
namespace TalkyTown
{
	// A relationship contains information on a person's feelings, thoughts, beliefs, etc. about another. It only applies in one direction
	public class Relationship
	{
		Person source;
		Person target;

		// Type of relation
		Enum relation = Relation.None;

		// Interpersonal feelings
		int love;
		int hate;
		int fear;
		int respect;
		int pity;
		int jealousy;
		int lust; // attraction?
        int crush;
        int anger;

        // Immediate feelings (prone to spontaneous actions)
        int imAnger;
		int imFear;

		public Relationship()
		{
		}
	}
}

