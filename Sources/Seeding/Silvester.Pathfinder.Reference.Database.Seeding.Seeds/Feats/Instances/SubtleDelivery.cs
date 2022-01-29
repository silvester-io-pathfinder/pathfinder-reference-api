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
    public class SubtleDelivery : Template
    {
        public static readonly Guid ID = Guid.Parse("14451e13-bfab-4aa9-9e26-60abfc8139a4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subtle Delivery",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("29da1bc2-1457-40b8-bdd9-b1c74ce742ed"), Type = TextBlockType.Text, Text = $"You can capably deliver toxins with a blowgun. Your {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("blowgun", Items.RangedWeapons.Instances.Blowgun.ID)} {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} can apply {ToMarkdownLink<Models.Entities.Trait>("injury", Traits.Instances.Injury.ID)} poisons even if they deal no damage due to a creature's resistance. If you critically succeed at an attack roll using a {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("blowgun", Items.RangedWeapons.Instances.Blowgun.ID)} loaded with a dart you've poisoned and the target rolls a failure on the poison's initial save, the target critically fails instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc22d03b-db72-4b90-a856-816db034204a"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("16ecbe75-3dd7-47b6-9f79-a29b56484296"), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b16bc31-8a12-4249-bd6c-d342134ac846"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
