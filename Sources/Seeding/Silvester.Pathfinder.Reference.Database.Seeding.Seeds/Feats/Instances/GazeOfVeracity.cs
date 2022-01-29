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
    public class GazeOfVeracity : Template
    {
        public static readonly Guid ID = Guid.Parse("43875848-a926-4298-bcd7-d510772ca03e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gaze of Veracity",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b7efe753-4113-4aac-8fa7-5091cbc26f1b"), Type = TextBlockType.Text, Text = $"You can channel your mask's power to pierce through lies and see the truth in any situation. Increase the number of Focus Points in your focus pool by 1. While wearing your mask, you can cast the {ToMarkdownLink<Models.Entities.Spell>("glimpse the truth", Spells.Instances.GlimpseTheTruth.ID)} cleric domain spell as a divine focus spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("52467ca8-1808-4ce1-9ec0-974ca2bbaf27"), Feats.Instances.HellknightSigniferDedication.ID);
            builder.HaveFocusPool(Guid.Parse("23e1efaa-2aa3-4ae7-b601-93f548421332"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4808b7e1-6f05-4bba-81e8-93cc08dc4543"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
