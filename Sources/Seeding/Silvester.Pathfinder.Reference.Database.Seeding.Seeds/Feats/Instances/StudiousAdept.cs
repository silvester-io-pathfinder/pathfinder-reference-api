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
    public class StudiousAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("77b65fe1-9fd5-41c0-b4a1-8b3fe935fd9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Studious Adept",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bbbe32b-073b-4141-be8b-03a24f0349e5"), Type = TextBlockType.Text, Text = $"You achieve a breakthrough in your exploration of magic. You gain {ToMarkdownLink<Models.Entities.Spell>("humanoid form", Spells.Instances.HumanoidForm.ID)} and {ToMarkdownLink<Models.Entities.Spell>("mirror image", Spells.Instances.MirrorImage.ID)} as 2nd-level arcane innate spells. You can cast each of these arcane innate spells once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6c2c416a-3e14-4a2e-867d-be412b9a5913"), Feats.Instances.StudiousMagic.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Anadi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9606fbf9-ffdf-4d3e-b64e-a31c5b0f6085"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
