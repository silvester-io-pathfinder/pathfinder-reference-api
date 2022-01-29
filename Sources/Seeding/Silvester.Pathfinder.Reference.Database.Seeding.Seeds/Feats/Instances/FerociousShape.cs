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
    public class FerociousShape : Template
    {
        public static readonly Guid ID = Guid.Parse("2abbf5bd-348b-4f4d-b0db-152d66d8104e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ferocious Shape",
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
            yield return new TextBlock { Id = Guid.Parse("a8b56b0e-425d-4e54-8c13-e6d87b68c531"), Type = TextBlockType.Text, Text = $"You have mastered the shape of ferocious dinosaurs. Add the forms listed in {ToMarkdownLink<Models.Entities.Spell>("dinosaur form", Spells.Instances.DinosaurForm.ID)} to your {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)} list. Whenever you use {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)} to take a form that grants you a specific Athletics modifier, you gain a +1 status bonus to your Athletics checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4932fab0-8a98-4f87-a89e-064e61c49fc0"), Feats.Instances.WildShape.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5905ca84-473f-463a-bd97-427066ff4035"), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4292e64c-8da8-45d9-abbb-890d2c8accac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
