using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("d08e0d10-2efd-41b1-b5fd-5ea56113e5ae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wild Strider",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b61edf59-da24-4978-9984-fe9070fc6aad"), Type = TextBlockType.Text, Text = "Natural obstacles pose no obstacle to you. You gain the ranger’s wild stride class feature. This allows you to ignore the effects of all non-magical difficult terrain, treat greater difficult terrain as merely difficult terrain, and gives you an additional benefit from (feat: Favored Terrain) based on the terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("23b1a6c8-6d50-4a7d-bf69-04d40f4779ef"), Feats.Instances.HorizonWalkerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ff8602f-0f12-4529-826c-fd8f843a5b6a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
