using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TailSpin : Template
    {
        public static readonly Guid ID = Guid.Parse("feed61c3-9848-452a-b298-76ea0a688c23");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tail Spin",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c54a0f6a-f8c8-4941-a69c-aeb53bcada4b"), Type = TextBlockType.Text, Text = "You excel at using your tail as a weapon to upend your foes. Attempt a single Athletics check to (action: Trip) up to two adjacent creatures. If you roll a success against a target, you get a critical success against that target instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("f591214a-8356-425b-bd75-1b4664e88a74"), Heritages.Instances.TailedGoblin.ID);
            builder.HaveSpecificFeat(Guid.Parse("4e49e501-1d88-4a58-b08f-be1acfbeb7a5"), Feats.Instances.HardTail.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bc6db21-7d70-456e-b3bd-56918aef9d56"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
