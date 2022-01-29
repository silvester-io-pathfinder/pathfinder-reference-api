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
    public class FlingingShove : Template
    {
        public static readonly Guid ID = Guid.Parse("9c3afefc-2c0e-4f8f-9075-d7c83a8088ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flinging Shove",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a71e340d-2150-452b-9433-5b7e5aa8036f"), Type = TextBlockType.Text, Text = $"Increase the distance you {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} your opponent with {ToMarkdownLink<Models.Entities.Feat>("Aggressive Block", Feats.Instances.AggressiveBlock.ID)} or {ToMarkdownLink<Models.Entities.Feat>("Brutish Shove", Feats.Instances.BrutishShove.ID)} to 10 feet on a success or 20 feet on a critical success. When you use {ToMarkdownLink<Models.Entities.Feat>("Aggressive Block", Feats.Instances.AggressiveBlock.ID)}, you can choose whether the target is flat-footed or {ToMarkdownLink<Models.Entities.SkillAction>("Shoved", SkillActions.Instances.Shove.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("1d2c1cda-2392-4f75-9b54-76137edbc66d"), Type = TextBlockType.Text, Text = $"When you make a {ToMarkdownLink<Models.Entities.Feat>("Brutish Shove", Feats.Instances.BrutishShove.ID)}, you also {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} the target 5 feet on a failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("4a9bf4ba-d2f8-4c15-9dab-7e4fac972cb0"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("224a46b7-103b-46d4-bdbb-e8022314392d"), Feats.Instances.AggressiveBlock.ID);
                or.HaveSpecificFeat(Guid.Parse("26ed4f46-3a13-4a17-a2a0-62641f1c270d"), Feats.Instances.BrutishShove.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c142ec19-a32d-4371-ad3e-943339f27994"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
