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
    public class AdditionalCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("3f3128b6-e816-4566-93e4-755a092eaaa3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Additional Companion",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once, gaining an additional animal companion each time, to a maximum of four total companions (including the one you gained from Beastmaster Dedication and possibly one you gained from sources other than the beastmaster archetype).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75bd6de6-647b-4927-87d9-df53841a8944"), Type = TextBlockType.Text, Text = $"Another animal joins you in your travels. It is a young animal companion that has the {ToMarkdownLink<Models.Entities.Trait>("minion", Traits.Instances.Minion.ID)} trait. Even though you have multiple animal companions, you can only have one “active companion” at a time. You can use {ToMarkdownLink<Models.Entities.Feat>("Call Companion", Feats.Instances.CallCompanion.ID)} to switch your active companion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8510bd93-9ed0-42de-a93c-6236891a49c6"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76da2160-302e-46ed-8634-3bf765cefa0c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
