using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Dualborn : Template
    {
        public static readonly Guid ID = Guid.Parse("30e107f8-3a24-4486-af60-0898e5fb33af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dualborn",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you take the (feat: Elemental Assault) or (feat: Elemental Bulwark) ancestry feats, you can use them only with your chosen elements. You can add your resistance from this feat to the resistance you gain from (feat: Elemental Bulwark) against effects with your elements' traits, for a total of 5 + half your level, or 10 + half your level with (feat: Improved Elemental Bulwark). If you take the (feat: Tetraelemental Assault) feat, you can choose each of your two elements twice each, instead of choosing each of the four elements once each.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4950f0f4-a09e-449d-8ca9-77c7cc4aad9b"), Type = TextBlockType.Text, Text = "Your suli heritage can be traced back to two geniekin ancestors of opposing elements, or to an elemental ancestor that embodied two combined elements. Choose two of the following elements: (trait: air), (trait: earth), (trait: fire), and (trait: water). Once made, this choice can’t be changed. You gain resistance equal to half your level (minimum 1) to all damaging effects with the traits of either of your chosen elements." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b531cdca-bd8c-4a0c-98e5-0033a91a61d6"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
