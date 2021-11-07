using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverpoweringCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("3a4fe852-3c16-406a-bf9f-64668f9396c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overpowering Charge",
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
            yield return new TextBlock { Id = Guid.Parse("1b807699-f2b7-4e17-9295-14e9e1303169"), Type = TextBlockType.Text, Text = "You trample foes as you charge past. When you use (feat: Barreling Charge) and successfully move through a creature’s space, that creature takes bludgeoning damage equal to your Strength modifier. On a critical success, the creature takes double damage and is flat-footed until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("438ff78e-22d7-43ab-9279-037fd2849ed0"), Feats.Instances.BarrelingCharge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4998a214-9bd0-4ef5-be9f-b59b952a7c83"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
