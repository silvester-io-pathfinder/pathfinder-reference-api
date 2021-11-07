using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodyBlows : Template
    {
        public static readonly Guid ID = Guid.Parse("539e5882-8faa-4873-803a-bdc3fc8cf1ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloody Blows",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8bfb6543-99d0-406f-86b7-5fb8d3cdef4b"), Type = TextBlockType.Text, Text = "Your lethal unarmed attacks leave bloody gouges or cause severe internal bleeding. When you critically hit with a (action: Strike) using an unarmed attack that isn&#39;t (trait: nonlethal), the target takes 1d4 persistent bleed damage. This can be because you&#39;re taking the penalty to use a fist for a lethal attack or because you have an unarmed attack without the (trait: nonlethal) trait due to (feat: Iron Fists), (feat: Tusks), or a similar ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd77d783-e488-411d-8ed3-52e96834962d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
