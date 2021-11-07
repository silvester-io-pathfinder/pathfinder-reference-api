using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChassisDeflection : Template
    {
        public static readonly Guid ID = Guid.Parse("46c3b1c4-9b9e-465c-8539-b23763ecf2a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Chassis Deflection",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A critical hit deals physical damage to you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1abb0325-4ad3-4904-897b-79ef1082c5ba"), Type = TextBlockType.Text, Text = "Attempt a DC 17 flat check. If you are successful, the attack becomes a normal hit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08324d02-7def-4994-8422-4fea1d871227"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
