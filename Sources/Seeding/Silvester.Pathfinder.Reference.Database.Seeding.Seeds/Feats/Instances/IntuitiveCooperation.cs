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
    public class IntuitiveCooperation : Template
    {
        public static readonly Guid ID = Guid.Parse("ad6be2df-b3bc-403d-8596-e2755a231e86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intuitive Cooperation",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5772d65-fe33-4bef-a6f1-455b4914a582"), Type = TextBlockType.Text, Text = $"~ Access: Jaric ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("ba30f793-2870-4c1e-8128-5b961df9e0a0"), Type = TextBlockType.Text, Text = $"You are accustomed to working alongside others, relying on each other to get by. You gain a +2 circumstance bonus to checks to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)}, and your allies gain a +2 circumstance bonus to checks to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} you." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f84697e-24a3-468a-b2ec-b62e205cea71"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
