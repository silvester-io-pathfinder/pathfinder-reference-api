using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleBeastmasterCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("b90998af-394a-472c-a87b-e07b4b2605d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Beastmaster Companion",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3fa42329-f6bc-4044-aae8-e966fe5e59f3"), Type = TextBlockType.Text, Text = "Your mature animal companions continue to grow and develop. They each become nimble or savage animal companions (your choice, choose for each companion, including those that become mature after you take this feat), gaining additional capabilities determined by the type of companion (page 214)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1a426e4a-7b59-410a-b5c9-3c95a281bdfd"), Feats.Instances.MatureBeastmasterCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b1336b4-84ac-4008-8f96-05f3ad6f5d01"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
