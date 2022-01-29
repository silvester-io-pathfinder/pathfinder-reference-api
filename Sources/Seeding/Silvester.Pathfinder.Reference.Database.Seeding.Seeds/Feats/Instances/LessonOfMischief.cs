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
    public class LessonOfMischief : Template
    {
        public static readonly Guid ID = Guid.Parse("2d83afdf-f732-4c6b-ad55-ec03465393ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Mischief",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1348b141-1d7c-428f-a950-3941a382c7c1"), Type = TextBlockType.Text, Text = $"~ Lesson Type: Greater" };
            yield return new TextBlock { Id = Guid.Parse("64b2cc65-0f82-49e9-ac68-9216b92846d6"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Spell>("deceiver's cloak", Spells.Instances.DeceiversCloak.ID)} hex, and your familiar learns {ToMarkdownLink<Models.Entities.Spell>("mad monkeys", Spells.Instances.MadMonkeys.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49547b11-6dd9-4ccd-b5c6-56db56505478"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
