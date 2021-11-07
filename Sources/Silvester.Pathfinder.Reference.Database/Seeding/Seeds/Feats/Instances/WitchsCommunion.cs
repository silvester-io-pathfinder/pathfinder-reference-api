using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WitchsCommunion : Template
    {
        public static readonly Guid ID = Guid.Parse("0d66ebb8-72a7-4537-9d52-8f963eaed536");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch's Communion",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5248664c-2f5f-4ba5-9f17-6e0edea234f3"), Type = TextBlockType.Text, Text = "You can keep watch over multiple charges. Each day during your preparations, you can designate a number of charges equal to your Intelligence modifier instead of just one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9da81807-122c-41ea-b445-52a38ba11294"), Feats.Instances.WitchsCharge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22e48bd1-3b26-4179-8c81-512485038480"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
