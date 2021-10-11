using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Special
{
    public class WishForLuckFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("e788185f-6337-4240-add3-04b4024e803b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wish for Luck",
                Level = 1,
                Frequency = "Once per day.",
                Trigger = "You are about to roll an attack roll, saving throw, or skill check.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d47b9cb7-df1f-4444-8911-7b58e649f8ec"), Type = TextBlockType.Text, Text = "You wish aloud for success. Roll the check twice and take the higher result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Arcane.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca3b196c-91f2-4137-8ed3-91a1b0270da7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
