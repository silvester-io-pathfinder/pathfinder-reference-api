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
    public class ArcaneFists : Template
    {
        public static readonly Guid ID = Guid.Parse("5d828644-cf8c-4ac0-8116-5493bf4d9823");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Fists",
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
            yield return new TextBlock { Id = Guid.Parse("bb6c347a-a801-4b7b-a024-761bbb3729ef"), Type = TextBlockType.Text, Text = $"Your physical training encompasses unarmed combat forms. The damage die for your fist changes to 1d6 instead of 1d4. You don't take the normal –2 circumstance penalty when making a lethal attack with your fist or any other unarmed attacks. Your unarmed attacks gain the {ToMarkdownLink<Models.Entities.Trait>("arcane", Traits.Instances.Arcane.ID)} trait, making them magical. At 5th level, you also gain the critical specialization effects of unarmed attacks in the brawling group and weapons in the brawling group." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Magus.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41896e40-15d7-46bb-9264-2035579ee85d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
