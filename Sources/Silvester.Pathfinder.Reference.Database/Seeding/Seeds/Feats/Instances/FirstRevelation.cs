using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirstRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("9c91f577-7e00-4f8b-8ea7-55afce1983e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "First Revelation",
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
            yield return new TextBlock { Id = Guid.Parse("96a362eb-b54f-4a1c-9131-b877ac5f00e9"), Type = TextBlockType.Text, Text = "You gain your mystery’s initial revelation spell. Casting this spell progresses your curse (APG pg. 70). Use the minor curse from your mystery, but when you progress it again, instead of your mystery’s moderate curse effect, you become flat-footed in addition to the effects of the minor curse." };
            yield return new TextBlock { Id = Guid.Parse("3c9a93a1-daad-45e8-8e1f-459990118dd2"), Type = TextBlockType.Text, Text = "If you don’t have one, you gain a focus pool of 1 Focus Point. You can (action: Refocus) by reconciling the conflicting nature of your mystery, which also reduces your curse to minor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("88ce1018-aef5-4c6d-8f85-27d9a1341f0e"), Feats.Instances.OracleDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c09c3ef-34b0-4ea0-bb03-8ee02566e16f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
