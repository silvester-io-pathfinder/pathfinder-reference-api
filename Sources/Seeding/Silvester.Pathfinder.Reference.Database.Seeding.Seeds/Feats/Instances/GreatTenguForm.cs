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
    public class GreatTenguForm : Template
    {
        public static readonly Guid ID = Guid.Parse("6fd64221-642f-45ac-b487-2a909f110b8b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Great Tengu Form",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8fbc1057-92c2-4925-a66b-9cf8b8d2a7ec"), Type = TextBlockType.Text, Text = $"You take on the imposing form of a large, winged oni. Once per day, as part of using {ToMarkdownLink<Models.Entities.Feat>("Long-Nosed Form", Feats.Instances.LongNosedForm.ID)}, you also gain the benefits of 4th-level {ToMarkdownLink<Models.Entities.Spell>("enlarge", Spells.Instances.Enlarge.ID)} and {ToMarkdownLink<Models.Entities.Spell>("fly", Spells.Instances.Fly.ID)}. This lasts for 5 minutes or until you shift out of your {ToMarkdownLink<Models.Entities.Feat>("Long-Nosed Form", Feats.Instances.LongNosedForm.ID)}, whichever happens first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dd0f0e84-2f87-4c12-bde4-62ab9e5e2993"), Feats.Instances.LongNosedForm.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbd4d8a9-fd61-46f8-812c-022800fa4a8c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
