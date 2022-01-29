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
    public class PowerfulShove : Template
    {
        public static readonly Guid ID = Guid.Parse("d9e4ae48-ad73-417e-ae15-4123359ca9d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Powerful Shove",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e5c4594-5431-4e81-b03a-b03ca40d1784"), Type = TextBlockType.Text, Text = $"You can push larger foes around with your attack. You can use {ToMarkdownLink<Models.Entities.Feat>("Aggressive Block", Feats.Instances.AggressiveBlock.ID)} or {ToMarkdownLink<Models.Entities.Feat>("Brutish Shove", Feats.Instances.BrutishShove.ID)} against a creature up to two sizes larger than you." };
            yield return new TextBlock { Id = Guid.Parse("ae17a046-bd97-4d15-9224-6b663f1f2bc9"), Type = TextBlockType.Text, Text = $"When a creature you {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} has to stop moving because it would hit an object, it takes damage equal to your Strength modifier (minimum 1). This happens regardless of how you {ToMarkdownLink<Models.Entities.SkillAction>("Shoved", SkillActions.Instances.Shove.ID)} the creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("71bb93ea-2611-4587-b0ef-2887a42f2d41"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("a8ee284a-25c4-43dc-83ab-9de319a1f7bc"), Feats.Instances.AggressiveBlock.ID);
                or.HaveSpecificFeat(Guid.Parse("4ff7b6c1-0001-4209-adcb-68ebf390a109"), Feats.Instances.BrutishShove.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c19b7758-c06d-4c87-aa77-2f25b3528043"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
