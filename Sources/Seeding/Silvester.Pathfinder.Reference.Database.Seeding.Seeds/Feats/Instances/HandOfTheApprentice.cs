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
    public class HandOfTheApprentice : Template
    {
        public static readonly Guid ID = Guid.Parse("0f8d5870-13da-43fb-83c8-5967c42b6328");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hand of the Apprentice",
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
            yield return new TextBlock { Id = Guid.Parse("75f6af76-89e7-4bc6-b3ce-5aa4f9e74e4b"), Type = TextBlockType.Text, Text = $"You can magically hurl your weapon at your foe. You gain the {ToMarkdownLink<Models.Entities.Spell>("hand of the apprentice", Spells.Instances.HandOfTheApprentice.ID)} universalist spell. Universalist spells are a type of focus spell, much like school spells. You start with a focus pool of 1 Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("8980f0c4-9835-4f88-918f-6ce13eacddf8"), Classes.Instances.Wizard.ID);
            builder.HaveNoMagicSchool(Guid.Parse("9ac09650-f37c-40d5-adb1-300e42a37165"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e51fb65-bc50-4a79-af74-fed665a8eca5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
