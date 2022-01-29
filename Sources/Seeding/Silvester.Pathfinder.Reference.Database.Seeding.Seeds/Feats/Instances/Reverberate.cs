using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Reverberate : Template
    {
        public static readonly Guid ID = Guid.Parse("a4306894-688b-4b5f-88ff-510c379b4c05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reverberate",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take sonic damage from a spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("118c03a4-63a9-4dd6-82cb-f9f92d59da2f"), Type = TextBlockType.Text, Text = $"You can manipulate the acoustics around you to deflect sonic damage back at its source. Attempt a Performance check against the spell DC of the creature that cast the triggering spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5d5e0fbd-0cf9-4a9a-8957-58695cc3bc5a"), Traits.Instances.Bard.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("9682bc04-b903-49fc-9ca0-4fdb31bbfb7b"),
                CriticalSuccess = "You reduce the triggering damage by an amount up to four times your level. The caster takes sonic damage equal to the amount of damage you reduced in this way.",
                Success = "As critical success, but you reduce the triggering damage by an amount up to twice your level.",
                
                CriticalFailure = "You misdirect the sonic waves at yourself, taking twice the triggering damage.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d497a938-45e4-4eb0-b1ba-2f4794bb293f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
