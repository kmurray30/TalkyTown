using System;
namespace TalkyTown
{
	public class Person: Being 
	{
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

