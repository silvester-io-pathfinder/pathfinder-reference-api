using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgileGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("a4bc5926-9f17-494c-bfd4-d864f2324a12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Agile Grace",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b964b884-cea4-43ab-a719-c76a39e5254f"), Type = TextBlockType.Text, Text = $"Your graceful moves with agile weapons are beyond compare. Your multiple attack penalty with {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} weapons and {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} unarmed attacks becomes -3 for your second attack and -6 for subsequent attacks (rather than -4 and -8)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f559da10-d5bb-4760-9e71-a36cb3df85fa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
