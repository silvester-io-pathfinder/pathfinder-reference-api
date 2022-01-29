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
    public class Sneaky : Template
    {
        public static readonly Guid ID = Guid.Parse("219fa113-eb9e-4648-b7ce-808edfb5cb2f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sneaky",
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
            yield return new TextBlock { Id = Guid.Parse("c52c8d54-3b54-4cb2-afde-72d0bf63cb89"), Type = TextBlockType.Text, Text = $"Stealth is an important tool in your arsenal. You can move 5 feet farther when you take the {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} action, up to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("878e1de3-7a96-4577-8de9-8a51e905f167"), Type = TextBlockType.Text, Text = $"In addition, as long as you continue to use Sneak actions and succeed at your Stealth check, you don't become observed if you don't have cover or greater cover and aren't concealed at the end of the {ToMarkdownLink<Models.Entities.SkillAction>("Sneak", SkillActions.Instances.Sneak.ID)} action, as long as you have cover or greater cover or are concealed at the end of your turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bf89e676-a5b8-4adf-a0a1-4e1acae3e5d1"), Traits.Instances.Hobgoblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b67f28dc-0e9e-42a0-887c-f7723d4d258e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
