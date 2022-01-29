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
    public class AnalyzeWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("751ec147-f1ac-42a7-be6b-2fc04f993f65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Analyze Weakness",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fb06338-e2a7-477b-87f2-2c7c3122bef9"), Type = TextBlockType.Text, Text = $"Your knowledge of a creature's physiology and understanding of tactics helps you attack with pinpoint accuracy. You carefully study a creature that you've identified to scope out particularly weak points in its positioning or physical form. The next time you deal sneak attack damage to the chosen creature with a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} before the end of your turn, add an additional 2d6 precision damage. At 11th and 17th levels, if your additional damage from sneak attack increases, increase the additional damage from Analyze Weakness to 3d6 at 11th level and 4d6 at 17th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("a72ded10-630e-4b8f-a08e-75d2ada42a64"), Classes.Instances.Rogue.ID);
            builder.HaveSpecificLevel(Guid.Parse("09f4d902-7024-48ad-aa66-eda62c449b1b"), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3b0a51f-b222-44af-8dbc-e6d5c7b76ea1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
