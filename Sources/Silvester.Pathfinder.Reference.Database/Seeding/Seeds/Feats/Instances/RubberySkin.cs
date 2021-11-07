using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RubberySkin : Template
    {
        public static readonly Guid ID = Guid.Parse("7967e9cb-7896-4ddc-9d7f-820fb9e822d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rubbery Skin",
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
            yield return new TextBlock { Id = Guid.Parse("21a1b103-db61-4e44-a2eb-a8277a5ec8be"), Type = TextBlockType.Text, Text = "Your skin develops a malleable, rubbery quality. You gain resistance to bludgeoning damage equal to 2 + your number of class feats from the oozemorph archetype. You also gain resistance equal to twice that amount to extra damage from critical hits; if the resistance is greater than the extra damage, it reduces the extra damage to 0 but doesn’t reduce the attack’s normal damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aa50f1ba-506e-414b-8cec-65bc1c99b810"), Feats.Instances.DisturbingDefense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ea4fff9-be7d-4c8d-a1d0-6cb9366c3454"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
