using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelingParry : Template
    {
        public static readonly Guid ID = Guid.Parse("473c813e-55e4-4b5f-bc0e-8b80e8b64ae7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dueling Parry",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81608ce0-cea7-4913-86eb-aeb9c5e91366"), Type = TextBlockType.Text, Text = "You can parry attacks against you with your one-handed weapon. You gain a +2 circumstance bonus to AC until the start of your next turn as long as you continue to meet the requirements." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dafe14b5-3a2d-4637-8432-78bea19e6287"), Feats.Instances.DuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a781723c-545e-47c8-a959-58f27f5fd5d5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
