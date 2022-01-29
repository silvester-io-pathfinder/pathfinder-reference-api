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
    public class OneForAll : Template
    {
        public static readonly Guid ID = Guid.Parse("9de62ddd-9f4c-4987-b60e-ebccadfa5b98");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One for All",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adba9dab-a215-4687-a5ea-cf638b8ff3f1"), Type = TextBlockType.Text, Text = $"With precisely the right words of encouragement, you bolster an ally's efforts. Designate an ally within 30 feet; this action counts as sufficient preparation to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} that ally. When you use the {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} reaction to help that ally, you can roll Diplomacy in place of the usual check. If your swashbuckler's style is wit and your Diplomacy check to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} meets or exceeds the very hard DC for your level, you gain panache." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("fd1fcadc-5de7-490b-83f3-94fa333e7506"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2669ec9e-b8ed-4631-aa48-35fe790397da"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("8cac7e90-efb3-4a8d-b40f-a1e4f945baaf"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("2bfd08ca-98b9-43a4-8d4c-e1b4a94b3090"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("122a3da8-591d-4212-8858-c31231688b0a"), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse("d8e256f9-b2ce-4c0a-9113-a25fddbc5184"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("42797883-1d40-4be4-94bc-59e09be00d1b"), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("817911bd-c825-47ea-b400-11b1dbc37cd4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
