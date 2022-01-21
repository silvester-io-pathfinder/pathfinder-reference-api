using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RubberySkin : Template
    {
        public static readonly Guid ID = Guid.Parse("6b4a5e6b-b85b-4f83-ae35-a1bf0e24fb09");

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
            yield return new TextBlock { Id = Guid.Parse("b3a6eb30-7cbe-4d3a-a332-298a0b0aeabe"), Type = TextBlockType.Text, Text = "Your skin develops a malleable, rubbery quality. You gain resistance to bludgeoning damage equal to 2 + your number of class feats from the oozemorph archetype. You also gain resistance equal to twice that amount to extra damage from critical hits; if the resistance is greater than the extra damage, it reduces the extra damage to 0 but doesn't reduce the attack's normal damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("096418cb-131e-4ce6-bb2f-d1946363c168"), Feats.Instances.DisturbingDefense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87464547-36ac-44ac-bd8f-1939e0257dfb"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
