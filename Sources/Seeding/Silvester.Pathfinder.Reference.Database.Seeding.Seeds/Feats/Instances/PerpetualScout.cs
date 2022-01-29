using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerpetualScout : Template
    {
        public static readonly Guid ID = Guid.Parse("d08c4302-ad7d-48b9-ad8b-2c199d42fec6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perpetual Scout",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe7e0114-4d79-4338-8246-b6114449eff4"), Type = TextBlockType.Text, Text = $"You spot anything out of place in the areas you know best. While in your favored terrain, you always gain the benefits of the {ToMarkdownLink<Models.Entities.Activity>("Scout", Activities.Instances.Scout.ID)} exploration activity, even if you are performing another exploration activity. If you're legendary in Survival, you gain these benefits in any terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("376458dc-e78c-413a-aa2c-107ad87d82e4"), Feats.Instances.HorizonWalkerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d3c0835-8e36-49ee-9fa9-96d68719c02f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
