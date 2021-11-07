using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WitchsHut : Template
    {
        public static readonly Guid ID = Guid.Parse("4bf2545b-2f68-4090-86de-8c5297aaa29f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch's Hut",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8f0e58c-e008-4b14-8afa-baacd4f15093"), Type = TextBlockType.Text, Text = "Your home is an animated structure that obeys your commands. By performing a rite that takes 1 day, you create an animated object from a hut, small house, covered wagon, tent, or similar construction of up to Huge size." };
            yield return new TextBlock { Id = Guid.Parse("2dbc0e9f-2e06-4710-9750-459981daf677"), Type = TextBlockType.Text, Text = "The hut uses your AC, saving throw modifiers, and Perception modifier and has 150 HP and Hardness 10. It has the construct armor ability, meaning once it’s reduced to less than half its Hit Points, or immediately upon being damaged by a critical hit, its AC is reduced by 4 until it is repaired." };
            yield return new TextBlock { Id = Guid.Parse("cdb2010d-0d82-4744-9c3d-20893b868f9c"), Type = TextBlockType.Text, Text = "The hut can’t attack or attempt skill checks. You can give the hut a command as a single action, which has the (trait: auditory) and (trait: concentrate) traits; after 1 round of reconfiguring itself, the hut then follows that command until you give it a different command." };
            yield return new TextBlock { Id = Guid.Parse("a756f9ef-0288-498d-b6f3-b1a2d3147b7e"), Type = TextBlockType.Enumeration, Text = " Guard: The hut watches for trespassers within 120 feet using your Perception modifier and screams if it spots any." };
            yield return new TextBlock { Id = Guid.Parse("b10bbdf7-ea1a-4f73-824f-e728cd424809"), Type = TextBlockType.Enumeration, Text = " Lock: Each entrance to the hut is sealed with a (spell: lock) spell." };
            yield return new TextBlock { Id = Guid.Parse("3b38ee2b-1c6c-42e2-970b-c908923547d1"), Type = TextBlockType.Enumeration, Text = " Move: The hut gains a Speed of 60 feet, growing giant bird or bone legs, if necessary, and follows an extremely basic movement command you give it, such as “follow me” or “move that direction.” While perfectly suitable for overland travel, the hut’s broad movements and 1-round delay on response time are too imprecise to predictably direct in a combat encounter or other situation where seconds and precise locations count." };
            yield return new TextBlock { Id = Guid.Parse("9663f62e-b631-458f-9925-da23b71c5ac6"), Type = TextBlockType.Enumeration, Text = " Hide: The hut appears to be a normal, mundane object of its type. This is a 10th-level (trait: illusion) effect." };
            yield return new TextBlock { Id = Guid.Parse("46f19e08-9a3e-4a7b-a99f-c9c32b86dbb5"), Type = TextBlockType.Text, Text = "You can have only one hut at a time. If you animate a new hut, your previous hut immediately reverts to its original, mundane form. If you die, the hut continues following the last order you gave it indefinitely." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ea47efc-de75-4d69-8831-5c20fd7cb236"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
