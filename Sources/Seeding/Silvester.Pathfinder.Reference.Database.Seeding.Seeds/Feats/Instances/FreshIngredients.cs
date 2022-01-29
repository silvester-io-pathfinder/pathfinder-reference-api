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
    public class FreshIngredients : Template
    {
        public static readonly Guid ID = Guid.Parse("8354101e-39d5-40bd-b542-c0fb9c6d9bdd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fresh Ingredients",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffa51a39-efd4-41a8-b3ac-04b2db4b79da"), Type = TextBlockType.Text, Text = $"When using {ToMarkdownLink<Models.Entities.Feat>("Natural Medicine", Feats.Instances.NaturalMedicine.ID)} to {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)}, you can spend a batch of herbs to gain the +2 circumstance bonus from having fresh ingredients, even if not in wilderness. If you spend a batch of herbs in wilderness, you gain a +4 circumstance bonus instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("031acae2-9da7-4e35-97f3-b8e4a347427e"), Feats.Instances.HerbalistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("3628da5c-2314-4a9b-8da9-db0f576f0b1e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73f5631b-b7b3-408c-a8eb-ee5b51a3a27d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
