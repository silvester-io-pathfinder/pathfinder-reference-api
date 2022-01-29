using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WitchsHut : Template
    {
        public static readonly Guid ID = Guid.Parse("c4a8cb51-a0c4-490a-b813-59d7e799b684");

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
            yield return new TextBlock { Id = Guid.Parse("56f719d7-e11e-4f19-bd4b-5a7ce50c366d"), Type = TextBlockType.Text, Text = $"Your home is an animated structure that obeys your commands. By performing a rite that takes 1 day, you create an animated object from a hut, small house, covered wagon, tent, or similar construction of up to Huge size." };
            yield return new TextBlock { Id = Guid.Parse("b8de8a38-671c-4d59-9487-4cdeb01bf125"), Type = TextBlockType.Text, Text = $"The hut uses your AC, saving throw modifiers, and Perception modifier and has 150 HP and Hardness 10. It has the construct armor ability, meaning once it's reduced to less than half its Hit Points, or immediately upon being damaged by a critical hit, its AC is reduced by 4 until it is repaired." };
            yield return new TextBlock { Id = Guid.Parse("b2f5a38f-27d3-4772-baa4-9f9c066a8dbc"), Type = TextBlockType.Text, Text = $"The hut can't attack or attempt skill checks. You can give the hut a command as a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} and {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} traits; after 1 round of reconfiguring itself, the hut then follows that command until you give it a different command." };
            yield return new TextBlock { Id = Guid.Parse("099fd0eb-2ffe-4a86-bacf-c81c5adf9fcb"), Type = TextBlockType.Enumeration, Text = $" Guard: The hut watches for trespassers within 120 feet using your Perception modifier and screams if it spots any." };
            yield return new TextBlock { Id = Guid.Parse("ef3d718d-fa9e-4b4d-a373-f18f3c4f9e6f"), Type = TextBlockType.Enumeration, Text = $" Lock: Each entrance to the hut is sealed with a {ToMarkdownLink<Models.Entities.Spell>("lock", Spells.Instances.Lock.ID)} spell." };
            yield return new TextBlock { Id = Guid.Parse("98537303-f65b-47e1-a04e-d1a30c174a9b"), Type = TextBlockType.Enumeration, Text = $" Move: The hut gains a Speed of 60 feet, growing giant bird or bone legs, if necessary, and follows an extremely basic movement command you give it, such as “follow me” or “move that direction.” While perfectly suitable for overland travel, the hut's broad movements and 1-round delay on response time are too imprecise to predictably direct in a combat encounter or other situation where seconds and precise locations count." };
            yield return new TextBlock { Id = Guid.Parse("15e71418-43de-4d71-9198-9dd68d8f3256"), Type = TextBlockType.Enumeration, Text = $" Hide: The hut appears to be a normal, mundane object of its type. This is a 10th-level {ToMarkdownLink<Models.Entities.Trait>("illusion", Traits.Instances.Illusion.ID)} effect." };
            yield return new TextBlock { Id = Guid.Parse("d21dc487-288b-4d9d-8433-8cc3b39ae24c"), Type = TextBlockType.Text, Text = $"You can have only one hut at a time. If you animate a new hut, your previous hut immediately reverts to its original, mundane form. If you die, the hut continues following the last order you gave it indefinitely." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2feb962a-40b5-41dd-9308-92421182e13f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
