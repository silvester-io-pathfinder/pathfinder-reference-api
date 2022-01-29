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
    public class ForgeDaysRest : Template
    {
        public static readonly Guid ID = Guid.Parse("4f5f3d1a-1bcb-48d8-907d-e6e148970ada");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forge-Day's Rest",
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
            yield return new TextBlock { Id = Guid.Parse("82196521-2777-4966-9967-e2111fd32e13"), Type = TextBlockType.Text, Text = $"~ Access: underground dwarf ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("a280f407-d31d-471d-afc9-504e2c913bd5"), Type = TextBlockType.Text, Text = $"Your unusual rest cycle allows you to recover faster. As long as you rest for 12 hours, you gain the effects of the {ToMarkdownLink<Models.Entities.Feat>("Fast Recovery", Feats.Instances.FastRecovery.ID)} general feat and you can go 20 hours without resting before becoming fatigued." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd6174d4-69c4-4e75-9c6e-e121fb368ff0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
