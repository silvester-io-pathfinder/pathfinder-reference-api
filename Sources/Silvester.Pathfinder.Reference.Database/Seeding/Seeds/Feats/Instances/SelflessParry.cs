using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SelflessParry : Template
    {
        public static readonly Guid ID = Guid.Parse("48f6fdeb-f158-473a-aec8-303b8b6ee2f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Selfless Parry",
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
            yield return new TextBlock { Id = Guid.Parse("337a53b2-b64a-41a2-a02c-b794abb48ae0"), Type = TextBlockType.Text, Text = "You protect those near you with a flash of steel. When you’re benefiting from (feat: Dueling Parry), allies adjacent to you gain a +1 circumstance bonus to AC. If you have (feat: Dueling Riposte), you can use it when an enemy within your reach critically fails a (action: Strike) against an ally adjacent to you, not just against yourself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("37146767-e40b-4bed-ae04-e517ae9c3b44"), Feats.Instances.DuelingParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63dc83cb-a99e-47c8-9d2b-f31c1a199248"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
