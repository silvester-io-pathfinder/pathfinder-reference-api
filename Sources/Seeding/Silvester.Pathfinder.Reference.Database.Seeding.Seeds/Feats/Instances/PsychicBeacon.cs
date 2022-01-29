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
    public class PsychicBeacon : Template
    {
        public static readonly Guid ID = Guid.Parse("cbb712e5-b4ee-4e64-95d1-9eeb990c1291");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Psychic Beacon",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27df9473-2437-423e-ac28-6d1af016de80"), Type = TextBlockType.Text, Text = $"As your spell strikes a target, you plant a beacon in their mind that announces their presence to those nearby. Use this amp in place of the psi cantrip's normal amp entry. The amped spell must be one that has one or more targets and must either require a spell attack roll or have a saving throw." };
            yield return new TextBlock { Id = Guid.Parse("e05a5501-1fb4-465f-b691-eb4ff63d4170"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("693c8ea0-d0dc-4541-a4d4-0b6b58fae5e2"), Type = TextBlockType.Text, Text = $"~ Amp: Choose one creature that's hit by the spell (if the spell has a spell attack roll) or that fails its save against the spell (if the spell requires a save). A magical beacon leaves telltale clues that make it easier to notice the creature for 1 minute. If the target was invisible, it's instead merely concealed for 1 minute. If it was concealed, it's no longer concealed for 1 minute, as the beacon clears up the concealment and makes it perfectly easy to see, even in areas of poor visibility." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f798f7d7-6cba-4ea2-a729-ed74c1c46ae6"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
