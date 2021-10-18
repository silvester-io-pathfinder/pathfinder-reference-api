using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Rogue : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Rogue",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.RogueDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’ve learned to sneak, steal, and disable traps. With time and luck, you’ll become capable of moving through the shadows, striking unseen, and escaping without notice." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Nearly any character can benefit from the many skills and tricks the rogue archetype grants." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Alchemist rogues can use the rogue’s Poison Weapon to great effect with their daily poisons, and sneak attack is a nice boost to bomb damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Barbarian rogues can become masters in every save and diversify their skills." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Champion rogues add damage from sneak attack while protecting their flanking partners from harm." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Fighter rogues combine the fighter’s accuracy with extra damage, a deadly combination for archers or finesse fighters." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Monk rogues have great synergy, since many stances grant powerful Strikes that work with sneak attack." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ranger rogues benefit from the shared focus on trailing foes and catching them flat-footed. The flurry edge can get you many sneak attacks, and the precision edge doubles down on precision damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Spellcaster rogues use the rogue multiclass to shore up skills or to pick up tricky rogue feats like Mobility to help keep them safe." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 229
            };
        }
    }
}
