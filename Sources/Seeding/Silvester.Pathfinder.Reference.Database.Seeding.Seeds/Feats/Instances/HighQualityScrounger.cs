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
    public class HighQualityScrounger : Template
    {
        public static readonly Guid ID = Guid.Parse("56434d77-1645-45fd-a390-71805988093d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "High-Quality Scrounger",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92bc6cba-d0a3-40e6-8c73-938e46d99fad"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} a temporary item using {ToMarkdownLink<Models.Entities.Feat>("Scrounger Dedication", Feats.Instances.ScroungerDedication.ID)}, it can be an item of up to 3rd level (though the item must still be a weapon, armor, or a nonconsumable piece of adventuring gear)." };
            yield return new TextBlock { Id = Guid.Parse("a1d06b01-bab6-4a89-a09b-349b64541f3c"), Type = TextBlockType.Text, Text = $"You can instead {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} it for someone else's use, allowing them to avoid taking the penalty for using a shoddy item when using it, but causing you to take the penalty if you use it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8d5f7ac7-b266-4491-8b96-43de59ecb016"), Feats.Instances.ScroungerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef46d947-e954-44e5-b28e-018ed9ebfa9e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
