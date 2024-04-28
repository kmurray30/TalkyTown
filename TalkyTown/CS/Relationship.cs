using System;
namespace TalkyTown
{
	// A relationship contains information on a person's feelings, thoughts, beliefs, etc. about another. It only applies in one direction
	public class Relationship
	{
		// Meta
		string name; // 

		// Type of relation
		Enum relation = Relation.None;

		// Feelings
		int love;
		int hate;
		int fear;
        int anger;
		int comfort;

        // Immediate feelings (prone to spontaneous actions)
        int imAnger;
		int imFear;

		/* Notes
		 * This basically just says how a person feels about a person or thing, mostly for evaluation purposes. After some sort of evaluation takes place, the person or thing is performed or not in a certain way
		 */

		public Relationship()
		{
		}
	}
}

