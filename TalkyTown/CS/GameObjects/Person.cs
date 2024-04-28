using System;
namespace TalkyTown
{
	public class Person: Being 
	{
		// Metadata
		int level; // This is how many levels down from the TrueView, where a true person is 0, a person as defined in their WV is 1, and a person in that person's WV is 2
		// Basic
		String name;

		// Attributes
		int intelligence;
		int charisma;
		int gossip;
		int diplomacy;
		int jealousy;
		int forgiveness;
		int mischief;

        // Skills
        int combat;
        int cooking;
        int dancing;

        // Engagements
        List<String> hobbies; // Should make these objects at some point
		List<String> jobs; // Should make these objects at some point

        // Interpersonal Relationships: [target, relationship]
        Dictionary<Person, Relationship> relationships;

		// Other: family tree? event timelines? object relationships? Domiciles?

		/* Notes:
		 * Fear of love/intimacy, how to model? (eg one might objectively catch romantic feelings, but react by percieving themselves as afraid of this person)
		 * Should track likes and dislikes
		 *	Activities / hobbies
		 *	objects liked
		 * 
		 * 
		 */


		// Tasks: things the character plans to do
		SortedList<int, Action> tasks;

		// Status
		int bored;
		int tired;
		int stressed;
		int engaged;
		int restless;

		// Objects in view (proximity to what they see/sense around them)
		Dictionary<GameObject, int> objectsInView;

        // Worldview
        WorldView worldView;

        public Person()
		{
		}

        /// <summary>
        /// Updates the person's view and triggers a delta
        /// </summary>
        /// <param name="key"></param>
        /// <param name="newValue"></param>
        /// <returns>True if value was changed</returns>
        public bool UpdateView(String key, String newValue)
		{
			return true;
		}
	}
}

