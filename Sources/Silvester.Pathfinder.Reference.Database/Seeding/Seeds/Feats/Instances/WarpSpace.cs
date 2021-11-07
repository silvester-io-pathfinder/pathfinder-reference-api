using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarpSpace : Template
    {
        public static readonly Guid ID = Guid.Parse("abf02bfc-51c1-4364-99fe-ce5f52437e66");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warp Space",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2500c0e3-4800-4e2d-b5d6-8d3ab95ec903"), Type = TextBlockType.Text, Text = "As you unleash your spell, you use your magic to bend and distort space, allowing your spell to strike your target from an unexpected vector. Use this amp in place of the psi cantrip’s normal amp entry. The amped psi cantrip must have a range." };
            yield return new TextBlock { Id = Guid.Parse("94e70620-5f50-4d85-9df1-6e5ca802f9f2"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("277cc949-b78c-48b9-a290-272a641df324"), Type = TextBlockType.Text, Text = "~ Amp: Choose a square within 30 feet and determine your spell’s line of effect and line of sight from there as well as whether creatures have cover against the spell. Any bonus from cover the target has is reduced by 2 against this spell. The spell still can’t exceed its normal range as measured from you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ba84377-26c4-456f-8750-f3cfd5e9c437"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
