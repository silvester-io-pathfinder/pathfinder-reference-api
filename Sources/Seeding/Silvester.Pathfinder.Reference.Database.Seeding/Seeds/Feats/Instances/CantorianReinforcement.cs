using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CantorianReinforcement : Template
    {
        public static readonly Guid ID = Guid.Parse("8920ed78-426a-466a-9e69-389802242177");

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
            yield return new TextBlock { Id = Guid.Parse("3bcaa64f-9649-4422-8dfb-d38f9cc95292"), Type = TextBlockType.Text, Text = "The life energy that helped create the first hobgoblins is particularly potent in you, protecting you from ongoing maladies. When you succeed at a saving throw against a disease or poison, you reduce the stage by 2 (or 1 for a virulent disease or poison), and when you critically succeed, you reduce the stage by 3 (or 2 for a virulent disease or poison)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03ff3af6-442d-46e4-adc0-5717dd619a5b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
