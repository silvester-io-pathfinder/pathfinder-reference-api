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
    public class LegendaryProfessional : Template
    {
        public static readonly Guid ID = Guid.Parse("d4978c74-737b-4c9e-b2c6-c1a01cb92cff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Professional",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d705d82-cdb3-48f6-8166-f284288b8af5"), Type = TextBlockType.Text, Text = $"Your fame has spread throughout the lands (for instance, if you have Warfare Lore, you might be a legendary general or tactician). This works as {ToMarkdownLink<Models.Entities.Feat>("Legendary Performer", Feats.Instances.LegendaryPerformer.ID)}, except you gain higher-level jobs when you {ToMarkdownLink<Models.Entities.SkillAction>("Earn Income", SkillActions.Instances.EarnIncome.ID)} with Lore." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyLoreProficiency(Guid.Parse("ec0f8acf-9e81-4baa-aceb-4b67ce69eec6"), Proficiencies.Instances.Legendary.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66e4b7bc-5c3a-4880-8f72-6de6d43733b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
