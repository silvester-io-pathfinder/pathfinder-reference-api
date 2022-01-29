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
    public class EnlargeCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("963a6624-e183-44f1-a819-d8a1c4b9241c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enlarge Companion",
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
            yield return new TextBlock { Id = Guid.Parse("233b0b4e-5cee-4f44-962f-97c3842548b5"), Type = TextBlockType.Text, Text = $"You make your companion enormous. You gain the {ToMarkdownLink<Models.Entities.Spell>("enlarge companion", Spells.Instances.EnlargeCompanion.ID)} warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAnimalCompanionAmount(Guid.Parse("97eb53e8-8219-4773-8e66-4a7aa5aa5d79"), Comparator.GreaterThanOrEqualTo, amount: 1);
            builder.HaveSpecificClass(Guid.Parse("d8a9eb6d-4b5c-4beb-b985-076b608c6cb0"), Classes.Instances.Ranger.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7af8ba26-5a2e-472c-a8d2-786773546bf6"), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2046709e-f512-490a-a278-d9d257260fa3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
