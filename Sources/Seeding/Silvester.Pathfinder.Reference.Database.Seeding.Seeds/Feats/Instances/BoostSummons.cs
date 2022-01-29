using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoostSummons : Template
    {
        public static readonly Guid ID = Guid.Parse("aa26fff8-1415-4761-8917-8ea77ca96316");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boost Summons",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc20b094-12e9-4abf-9282-2035d5694e8a"), Type = TextBlockType.Text, Text = $"Augmenting your eidolon extends to creatures you summon. When you cast {ToMarkdownLink<Models.Entities.Spell>("boost eidolon", Spells.Instances.BoostEidolon.ID)}, in addition to your eidolon, it also targets your summoned creatures within 60 feet." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("213cab80-91cc-4f10-ad75-674305aa8634"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
