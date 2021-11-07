using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FiendishForm : Template
    {
        public static readonly Guid ID = Guid.Parse("890113bc-8d01-4002-b494-8b3a062ce7fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Form",
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
            yield return new TextBlock { Id = Guid.Parse("988f08b0-a0d4-44e8-810a-9e501da93b7d"), Type = TextBlockType.Text, Text = "Your features reshape into those of a type of fiend who serves your deity; for example, as a demon you might have putrid scales, twisted horns, and red eyes. You gain a fly Speed equal to your Speed. You gain darkvision if you don’t already have it, and you gain the fiend trait and the trait appropriate to the type of servitor you’ve become (such as daemon, demon, or devil)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("904daafc-27df-469a-adf3-ee6c3be52f25"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3a50d30-59ab-48f8-ba76-dceb292bf46c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
