using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastsCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("bdc7ab5e-6fe3-4917-a5e7-3c9df0d88472");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beast's Charge",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ff86001-d938-4b63-9b89-48479a82030d"), Type = TextBlockType.Text, Text = "Your eidolon rushes forward, using its momentum to increase the power of its attack. Your eidolon (action: Strides | Stride) twice and then (action: Strikes | Strike). If the eidolon moved at least 20 feet away from its starting position and moved entirely in a straight line, it gains a +1 circumstance bonus to this attack roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f27fba9-d42a-4f9f-8d18-a8b4dc88a2cf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
