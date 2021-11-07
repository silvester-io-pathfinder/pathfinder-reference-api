using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MightyDragonShape : Template
    {
        public static readonly Guid ID = Guid.Parse("edb1ac1a-5fcd-4c3f-8960-7311ebfb8f74");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mighty Dragon Shape",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd406b33-88fc-4a0d-ba3b-d0d53b88b53a"), Type = TextBlockType.Text, Text = "You’ve practiced and increased your draconic might, allowing you to take your draconic form more often. You can use (feat: Shape of the Dragon) once per hour instead of once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e90e5ad-75ba-4575-b80d-a3f4010c2f35"), Feats.Instances.ShapeOfTheDraon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e02d65f-7c89-40b3-b47a-f65c71b72f6d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
