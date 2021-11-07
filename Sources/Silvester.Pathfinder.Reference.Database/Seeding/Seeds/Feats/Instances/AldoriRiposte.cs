using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AldoriRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("0b9c3bf5-fdcb-417f-889d-f6a764c1d6b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aldori Riposte",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An opponent within your reach critically fails a Strike against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("957a056c-4ba1-4123-b309-77a03c83598e"), Type = TextBlockType.Text, Text = "You riposte with your Aldori dueling sword when your enemy leaves an opening. Make a melee (action: Strike) or use a (action: Disarm) action against the triggering opponent using your Aldori dueling sword." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f174fe1e-b11e-4d34-9f3d-d6685cb33d8a"), Feats.Instances.AldoriParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("304910a4-2e29-43ab-8bf1-1950e95b4fc9"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
