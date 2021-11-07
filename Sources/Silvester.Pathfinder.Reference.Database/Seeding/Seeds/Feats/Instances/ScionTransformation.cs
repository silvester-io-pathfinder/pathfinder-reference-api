using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScionTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("7b5243ad-9c7b-4af1-a4c6-182838327196");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scion Transformation",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6cdfc60d-7a80-4f34-9125-3bdd6e8b5f08"), Type = TextBlockType.Text, Text = "You go into hibernation for 24 hours and perform a ritual dedicated to your ancestors, undergoing a one-time metamorphosis. You permanently gain the effects of (spell: enlarge), and your maximum Hit Points increase by your level. The ritual transforms most of your gear to the appropriate size for your new body (though powerful items like artifacts or items strongly tied to their original size may not transform, at the GM’s discretion)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63dc577c-85ac-4719-8349-6f0add5e4388"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
