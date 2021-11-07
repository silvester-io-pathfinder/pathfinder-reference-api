using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CantorianReinforcement : Template
    {
        public static readonly Guid ID = Guid.Parse("caa6712c-9608-4ac4-84e9-a1d187e64f60");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cantorian Reinforcement",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2d3c68f-7a0b-4007-8cb2-058fc64098e7"), Type = TextBlockType.Text, Text = "The life energy that helped create the first hobgoblins is particularly potent in you, protecting you from ongoing maladies. When you succeed at a saving throw against a disease or poison, you reduce the stage by 2 (or 1 for a virulent disease or poison), and when you critically succeed, you reduce the stage by 3 (or 2 for a virulent disease or poison)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea383fa7-2ea2-40b8-a04e-b5398bbab817"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
