using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DispellingSlice : Template
    {
        public static readonly Guid ID = Guid.Parse("a3ac237b-079d-49b4-bcba-c1698bc645b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dispelling Slice",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3940a522-9a70-4a7c-a8f7-a98a1862fe7b"), Type = TextBlockType.Text, Text = "Your sneak attack slices through the threads binding magic to a target. Make a (action: Strike) against a flat-footed creature (your choice). If your (action: Strike) deals sneak attack damage, you attempt to counteract a single spell active on the target. Your counteract level is equal to your rogue level, and your counteract check modifier is equal to half your level (rounded up)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d019757-1195-4b18-833c-8ab4ab887be1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
