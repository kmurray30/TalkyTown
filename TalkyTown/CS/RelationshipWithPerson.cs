using System;
namespace TalkyTown
{
	// A relationship contains information on a person's feelings, thoughts, beliefs, etc. about another. It only applies in one direction
	public class RelationshipWithPerson : Relationship
	{
		// Type of personal relation
		Enum relation = Relation.None;

		// Interpersonal feelings
		int respect;
		int pity;
		int jealousy;
		int lust; // attraction?
        int crush;

        // Immediate feelings (prone to spontaneous actions)
		int imRespect;

		public RelationshipWithPerson()
		{
		}
	}
}

