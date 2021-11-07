using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PterosaurSwoop : Template
    {
        public static readonly Guid ID = Guid.Parse("39619dc9-2772-490a-916d-fe511c91290d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pterosaur Swoop",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ef9b3e6-2a13-43c1-9e81-1cf947c00a09"), Type = TextBlockType.Text, Text = "The pterosaur (action: Flies | Fly) up to its Speed and makes one beak (action: Strike) at any point during that movement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6a7b1c0-8ee4-4d50-b53a-10504d1b2d26"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
