using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Rogue : Template
    {
        public static readonly Guid ID = Guid.Parse("51706f23-5200-46c3-bb83-559acc1c16b7");
        
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
            yield return new TextBlock { Id = Guid.Parse("6e9283ed-f26b-46f9-9432-ddce2892d5cc"), Type = TextBlockType.Text, Text = "you've learned to sneak, steal, and disable traps. With time and luck, you'll become capable of moving through the shadows, striking unseen, and escaping without notice." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f01a3c40-c5e1-4866-a37f-5df16313d520"), Type = TextBlockType.Text, Text = "Nearly any character can benefit from the many skills and tricks the rogue archetype grants." };
            yield return new TextBlock { Id = Guid.Parse("7a80071a-a2c0-4c55-887f-1c1dbb86d813"), Type = TextBlockType.Enumeration, Text = "Alchemist rogues can use the rogue's Poison Weapon to great effect with their daily poisons, and sneak attack is a nice boost to bomb damage." };
            yield return new TextBlock { Id = Guid.Parse("fee230e9-f51c-494d-93db-c13bfc3155f3"), Type = TextBlockType.Enumeration, Text = "Barbarian rogues can become masters in every save and diversify their skills." };
            yield return new TextBlock { Id = Guid.Parse("0ebfbad6-1207-4cbc-b4d0-6f9d59310d84"), Type = TextBlockType.Enumeration, Text = "Champion rogues add damage from sneak attack while protecting their flanking partners from harm." };
            yield return new TextBlock { Id = Guid.Parse("9fabab90-813e-44d7-b68e-8430c2e93a74"), Type = TextBlockType.Enumeration, Text = "Fighter rogues combine the fighter's accuracy with extra damage, a deadly combination for archers or finesse fighters." };
            yield return new TextBlock { Id = Guid.Parse("fddbe6f3-77c4-4531-bf6d-8dc67023e8c1"), Type = TextBlockType.Enumeration, Text = "Monk rogues have great synergy, since many stances grant powerful Strikes that work with sneak attack." };
            yield return new TextBlock { Id = Guid.Parse("680197f6-b34c-4990-ae2b-22586d516e0f"), Type = TextBlockType.Enumeration, Text = "Ranger rogues benefit from the shared focus on trailing foes and catching them flat-footed. The flurry edge can get you many sneak attacks, and the precision edge doubles down on precision damage." };
            yield return new TextBlock { Id = Guid.Parse("80665341-10ed-4e87-95b2-cbad15ba9bea"), Type = TextBlockType.Enumeration, Text = "Spellcaster rogues use the rogue multiclass to shore up skills or to pick up tricky rogue feats like Mobility to help keep them safe." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b715c8b-37a9-4139-9e3d-bbd77e397b93"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 229
            };
        }
    }
}
