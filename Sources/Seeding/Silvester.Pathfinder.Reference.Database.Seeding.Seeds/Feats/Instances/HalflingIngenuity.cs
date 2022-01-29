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
    public class HalflingIngenuity : Template
    {
        public static readonly Guid ID = Guid.Parse("52dbd445-d246-4ce9-96a4-9b3248453e93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Ingenuity",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b0ae57f-d3f8-4d1b-8824-8efdfaf66c3c"), Type = TextBlockType.Text, Text = $"While your willingness to dig into a task you know little about might get you into trouble, your incredible luck often saves you from danger. You can attempt skill actions that normally require you to be trained even if you aren't trained in that skill. If you use {ToMarkdownLink<Models.Entities.Feat>("Halfling Luck", Feats.Instances.HalflingLuck.ID)} when you fail a check for a skill with which you are untrained, you can add a proficiency bonus equal to your level, rather than 0, when you reroll the triggering skill check. You gain a +4 circumstance bonus to this rerolled skill check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("abe0bc4c-ca21-4c20-98be-e88abcfaf7a6"), Feats.Instances.HalflingLuck.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("338fef4f-99f8-45b0-be7c-26ee64d9bf36"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
