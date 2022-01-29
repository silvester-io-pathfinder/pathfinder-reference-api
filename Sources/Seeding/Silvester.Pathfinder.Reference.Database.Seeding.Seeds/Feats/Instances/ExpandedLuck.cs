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
    public class ExpandedLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("feef068f-b7d9-44f8-b1b1-f5e64abc1f7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expanded Luck",
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
            yield return new TextBlock { Id = Guid.Parse("54ec92d2-3e08-48c2-b96f-38f2c2df0e13"), Type = TextBlockType.Text, Text = $"You are luckier even than most catfolk. You can trigger {ToMarkdownLink<Models.Entities.Feat>("Cat's Luck", Feats.Instances.CatsLuck.ID)} when you fail or critically fail a Fortitude or Will saving throw in addition to Reflex saving throws. You still can use {ToMarkdownLink<Models.Entities.Feat>("Cat's Luck", Feats.Instances.CatsLuck.ID)} only once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b39ed142-eab3-4bc2-8f62-639d93fe2b57"), Feats.Instances.CatsLuck.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bbf63ff5-49b9-4558-96eb-fe3d2bc54204"), Traits.Instances.Catfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d2e88fc-2a6a-4149-925e-2ff38c2f9ac7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
