using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedCommunalHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("b6c09338-ae3d-4026-ba41-b26d5754cabd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Communal Healing",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c435f5a3-e886-4feb-a88d-d2091fb20dd3"), Type = TextBlockType.Text, Text = "You can direct excess channeled energy outward to benefit an ally. You can grant the Hit Points you would regain from (feat: Communal Healing) to any one creature within the range of your (spell: heal) spell instead of yourself. You can also use (feat: Communal Healing) when you target only yourself with a (spell: heal) spell, though if you do, you must grant the additional healing to someone other than yourself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0334a6ca-e466-4a6b-9a59-deac5711cec9"), Feats.Instances.CommunalHealing.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("753162a6-3a37-4bdf-b4a1-22e6b39a47c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
