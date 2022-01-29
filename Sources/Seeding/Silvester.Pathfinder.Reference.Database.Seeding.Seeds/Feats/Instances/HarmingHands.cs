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
    public class HarmingHands : Template
    {
        public static readonly Guid ID = Guid.Parse("a6a81553-450e-44f5-8dad-07697c440f05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harming Hands",
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
            yield return new TextBlock { Id = Guid.Parse("d5cfef49-a6fe-4e25-adcd-708f63f8c593"), Type = TextBlockType.Text, Text = $"The mordant power of your negative energy grows. When you cast {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)}, you roll d10s instead of d8s." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("f794a6b5-f9b6-4d33-8db6-402fd2bb83e4"), DivineFonts.Instances.Harm.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e1bf00c7-d20e-405e-8d9f-d89325cb5c49"), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3397371a-94fb-41d5-9733-cee7c9e8bac2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
