using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarpSpace : Template
    {
        public static readonly Guid ID = Guid.Parse("1d9286f4-cbda-44c5-a59b-3d39a03a77aa");

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
            yield return new TextBlock { Id = Guid.Parse("37a4fca2-91a6-4bd7-be61-73c45bb9bb5a"), Type = TextBlockType.Text, Text = $"As you unleash your spell, you use your magic to bend and distort space, allowing your spell to strike your target from an unexpected vector. Use this amp in place of the psi cantrip's normal amp entry. The amped psi cantrip must have a range." };
            yield return new TextBlock { Id = Guid.Parse("a4d3b5d8-d360-4be5-bd1a-71859203cb18"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("62c54c26-6fe1-4313-82f2-b3817fa7dd09"), Type = TextBlockType.Text, Text = $"~ Amp: Choose a square within 30 feet and determine your spell's line of effect and line of sight from there as well as whether creatures have cover against the spell. Any bonus from cover the target has is reduced by 2 against this spell. The spell still can't exceed its normal range as measured from you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f50a514-fc8c-46e2-8823-d38f6fcfea6e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
