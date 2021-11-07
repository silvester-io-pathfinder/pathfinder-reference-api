using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonWaterElemental : Template
    {
        public static readonly Guid ID = Guid.Parse("01c0966f-721f-4d22-b214-1f13af2af589");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Water Elemental",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82e8f55e-e8aa-4fec-a3ac-6e10c6f5e539"), Type = TextBlockType.Text, Text = "You can summon an elemental ally. Once per day, you can cast (spell: summon elemental) as a 5th-level primal innate spell, but the elemental summoned must be a (trait: water) elemental." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12d862ea-97ee-4831-a49c-a458fdf337e3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
