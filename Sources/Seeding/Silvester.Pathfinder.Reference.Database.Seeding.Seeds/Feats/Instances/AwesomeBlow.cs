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
    public class AwesomeBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("89cc0da7-d8b7-4b87-9ffe-328f1dd39996");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Awesome Blow",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6314908-28b9-4a0e-8e5b-70cda1e4994e"), Type = TextBlockType.Text, Text = $"Your attacks are so powerful, they can flatten your opponents. When you use {ToMarkdownLink<Models.Entities.Feat>("Knockback", Feats.Instances.Knockback.ID)}, you can attempt an Athletics check against your target's Fortitude DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f78b1ea3-0ac4-4e1a-be85-bd769bc1cc81"), Feats.Instances.Knockback.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("8465e080-c0b3-44fb-9dbd-6c1f043cf286"),
                CriticalSuccess = "You gain the critical success effect of a (action: Shove), then the critical success effect of a (action: Trip) against the target.",
                Success = "You gain the success effect of a (action: Shove), then the success effect of a (action: Trip) against the target.",
                Failure = "You gain the normal effect of (feat: Knockback).",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33f5f596-7ea4-48e3-9d22-27cef6b2a752"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
