using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RangersBramble : Template
    {
        public static readonly Guid ID = Guid.Parse("6b82296e-78d3-4ee9-a35c-ff914723c551");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ranger's Bramble",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d70fcc1f-d93d-4c1d-9fee-5be9d7d1974e"), Type = TextBlockType.Text, Text = "You can cause plants to grow and trap your foes with thorns. You gain the (spell: ranger’s bramble) warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("adcd682d-c772-48c7-8f65-5a4686b13e3e"), Classes.Instances.Ranger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("deaeb890-8b95-4b22-abc7-722451944d4b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
