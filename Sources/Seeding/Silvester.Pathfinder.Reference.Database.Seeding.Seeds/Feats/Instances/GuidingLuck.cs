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
    public class GuidingLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("31e9c736-7d2d-4e86-9f28-1471c051fa8f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guiding Luck",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2de2cede-5f66-4641-ad7c-a45760e51bb6"), Type = TextBlockType.Text, Text = $"Your luck guides you to look the right way and aim your blows unerringly. You can use {ToMarkdownLink<Models.Entities.Feat>("Halfling Luck", Feats.Instances.HalflingLuck.ID)} twice per day: once in response to its normal trigger, and once when you fail a Perception check or attack roll instead of the normal trigger." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7a13fe1c-3ebf-432a-9d8f-86f6f3aacb19"), Feats.Instances.HalflingLuck.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9b535c49-b06c-4ed5-a830-7f61b0b2f9b9"), Traits.Instances.Halfling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a845e50b-ddc8-429b-a82b-9d2d4bc117a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
