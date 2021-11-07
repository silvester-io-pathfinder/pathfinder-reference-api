using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DispellingSlice : Template
    {
        public static readonly Guid ID = Guid.Parse("d7596e1c-43d9-48ea-818c-b731860bc0ad");

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
            yield return new TextBlock { Id = Guid.Parse("be9e559e-e476-4e54-b37f-d3d509c82658"), Type = TextBlockType.Text, Text = "Your sneak attack slices through the threads binding magic to a target. Make a (action: Strike) against a flat-footed creature (your choice). If your (action: Strike) deals sneak attack damage, you attempt to counteract a single spell active on the target. Your counteract level is equal to your rogue level, and your counteract check modifier is equal to half your level (rounded up)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c080b1a6-d860-41ca-9796-c4ae40c3d4ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
