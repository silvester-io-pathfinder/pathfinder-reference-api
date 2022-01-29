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
    public class ResoundingCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("87df8954-4b48-4140-8213-02a0784b8c1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resounding Cascade",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Arcane Cascade.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae6237c2-8539-40a7-8e09-59cec35d8959"), Type = TextBlockType.Text, Text = $"When you enter your {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)}, you disperse the magical reinforcement to nearby allies. You grant the extra damage of {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)} in an aura affecting all allies in a 5-foot emanation. This uses only the base damage of the stance, based on the ally's weapon specialization; it doesn't use any increase you get from bonuses, the laughing shadow hybrid study, or the like. As normal for duplicate effects, multiple {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascades", Feats.Instances.ArcaneCascade.ID)} affecting the same creature aren't cumulative." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("60fb2717-2023-4eed-9697-241808eebc0f"), Feats.Instances.ArcaneCascade.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99b11440-76c5-4c5c-8b75-78838320543f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
