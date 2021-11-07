using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BastionDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("23134b7d-2d40-4647-9f72-58710bf86315");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bastion Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the bastion archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1a8921d-c25a-4dd1-b2a1-21bc870285a0"), Type = TextBlockType.Text, Text = "You are particularly skilled at using a shield in combat. You gain the (feat: Reactive Shield) fighter feat. This fulfills any prerequisites requiring (feat: Reactive Shield) as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19d9bb94-900c-41af-8656-ffcb4ef44747"), Feats.Instances.ShieldBlock.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3083d405-eb73-471d-b39d-df98fe7bcdb6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
