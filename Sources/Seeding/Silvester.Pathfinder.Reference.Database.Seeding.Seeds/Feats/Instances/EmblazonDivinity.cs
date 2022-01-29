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
    public class EmblazonDivinity : Template
    {
        public static readonly Guid ID = Guid.Parse("ac51dfd0-9c95-48d1-ae23-bfc018c030e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emblazon Divinity",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42a31437-3f5c-4634-a6ac-6ac49f38fbeb"), Type = TextBlockType.Text, Text = $"Your sacred etchings imbue objects with power. It takes you only 1 minute to emblazon a symbol using {ToMarkdownLink<Models.Entities.Feat>("Emblazon Armament", Feats.Instances.EmblazonArmament.ID)}, and you can have up to four symbols emblazoned at a time. Each item can still have only one symbol emblazoned upon it, and if you exceed the limit of four, the oldest symbol disappears. These symbols can benefit even those who don't follow the deity, provided they aren't directly opposed (as determined by the GM)." };
            yield return new TextBlock { Id = Guid.Parse("a5543d16-1d4c-4e08-b0e1-375105c024a0"), Type = TextBlockType.Text, Text = $"You can select a different benefit for each emblazoned symbol, chosen from any you have from {ToMarkdownLink<Models.Entities.Feat>("Emblazon Armament", Feats.Instances.EmblazonArmament.ID)} or other feats such as {ToMarkdownLink<Models.Entities.Feat>("Emblazon Energy", Feats.Instances.EmblazonEnergy.ID)} or {ToMarkdownLink<Models.Entities.Feat>("Emblazon Antimagic", Feats.Instances.EmblazonAntimagic.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("107aaba3-2c44-4985-a753-b26d4b43a58d"), Feats.Instances.EmblazonArmament.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5e85715e-7f69-41bf-861c-52a45ca48421"), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32f973ab-8efe-45b9-8d99-0493a52df0de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
