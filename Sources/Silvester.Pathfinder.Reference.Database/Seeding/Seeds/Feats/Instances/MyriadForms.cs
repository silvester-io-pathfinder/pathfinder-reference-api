using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MyriadForms : Template
    {
        public static readonly Guid ID = Guid.Parse("256a53ce-598a-425d-81cd-588f03c6779a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Myriad Forms",
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
            yield return new TextBlock { Id = Guid.Parse("de9ccdac-7c97-4acb-9f36-d30e38d6f474"), Type = TextBlockType.Text, Text = "With a bit of self-discovery, you find a new form. You gain the alternate form of a kitsune heritage other than your own, adding it to the options for your (action: Change Shape | Change Shape - Kitsune)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cd568e1-50aa-48be-bd5e-19d70b68f9ea"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
