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
    public class VerySneaky : Template
    {
        public static readonly Guid ID = Guid.Parse("33752d4d-4cba-4030-ab94-b9a5f5767606");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Very Sneaky",
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
            yield return new TextBlock { Id = Guid.Parse("509f0aad-43f8-47d5-995b-2d2d550a38b7"), Type = TextBlockType.Text, Text = $"Taller folk rarely pay attention to the shadows at their feet, and you take full advantage of this. You can move 5 feet farther when you take the {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} action, up to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("c37de2ee-2d5f-4988-a4ed-2d7e47303664"), Type = TextBlockType.Text, Text = $"In addition, as long as you continue to use {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} actions and succeed at your Stealth check, you don't become observed if you don't have cover or greater cover and aren't concealed at the end of the {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} action, as long as you have cover or greater cover or are concealed at the end of your turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d597ca5c-b2c7-46d6-aba8-cfa146204b2f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
