using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrototypeCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("6f17a13c-4c42-4691-a5df-d0231f767394");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prototype Companion",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2a14093-aeba-415d-b0c3-0c8e6c3607d4"), Type = TextBlockType.Text, Text = "You have created a construct companion, and while it might not be an innovation, it serves as a trustworthy minion. You gain a prototype construct companion (G&amp;G pg. 32)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("734b01c5-2707-41e7-8387-b96ed14ffc81"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
