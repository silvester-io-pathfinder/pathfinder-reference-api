using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivinerSense : Template
    {
        public static readonly Guid ID = Guid.Parse("8f2daa37-438e-4aff-ac6e-5b96c2c5c390");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diviner Sense",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb9ead8f-1210-4dc1-85db-c513ec4a259f"), Type = TextBlockType.Text, Text = $"You sense magical dangers. When using the {ToMarkdownLink<Models.Entities.Activity>("Detect Magic", Activities.Instances.DetectMagic.ID)} exploration activity, you can roll initiative twice and use the better result so long as at least one opponent has a {ToMarkdownLink<Models.Entities.Trait>("magical", Traits.Instances.Magical.ID)} effect or magic item and is in range of your {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5506376-e193-4d82-aa7f-d82ec23f46de"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
