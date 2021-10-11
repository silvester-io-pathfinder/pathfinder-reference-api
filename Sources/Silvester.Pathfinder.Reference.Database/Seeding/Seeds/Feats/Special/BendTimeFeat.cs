using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Special
{
    public class BendTimeFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("5a266bc3-b871-441a-bc4b-92407b2bad54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bend Time",
                Level = 1,
                Frequency = "Once per day.", 
                Trigger = "Your turn begins.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11fc4b38-c22b-4b01-b3e6-80e255f96720"), Type = TextBlockType.Text, Text = "You are quickened this turn. You can use your extra action to Stride." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Occult.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54d69bba-b42b-4212-a6c3-5ef87dd4ab50"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 31
            };
        }
    }
}
