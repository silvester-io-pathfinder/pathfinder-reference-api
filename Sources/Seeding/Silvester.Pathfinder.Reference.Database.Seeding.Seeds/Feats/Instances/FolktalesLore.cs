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
    public class FolktalesLore : Template
    {
        public static readonly Guid ID = Guid.Parse("d5aca305-bb73-472d-9eab-737bfc46a9b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Folktales Lore",
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
            yield return new TextBlock { Id = Guid.Parse("910d9809-2ce7-4539-a8bb-e514a6c0377d"), Type = TextBlockType.Text, Text = $"You can pull bits of wisdom from any tale. You become trained in Folktales Lore, a special Lore skill that can be used only to Recall Knowledge, but on any topic. If you fail a check to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} with Folktales Lore, you get the effects of the {ToMarkdownLink<Models.Entities.Feat>("Dubious Knowledge", Feats.Instances.DubiousKnowledge.ID)} skill feat." };
            yield return new TextBlock { Id = Guid.Parse("d262ffad-d79c-4888-a759-e211c795a8e8"), Type = TextBlockType.Text, Text = $"If you are legendary in the Performance skill, you gain expert proficiency in Folktales Lore, but you can't increase your proficiency rank in Folktales Lore by any other means." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7bff9dcb-4af1-4a19-b2de-019888563cd4"), Feats.Instances.FolkloristDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("529fddb5-6f13-4049-a0bb-9315b25e83fd"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d627a881-37db-4256-9b5e-ba9971f23a67"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
