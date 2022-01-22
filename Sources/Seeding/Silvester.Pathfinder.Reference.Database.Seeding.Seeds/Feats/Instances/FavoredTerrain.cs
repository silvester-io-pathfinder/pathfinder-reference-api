using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FavoredTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("dfdb130b-839a-4094-b534-7d965af21292");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Favored Terrain",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d4d2be4-0161-4a71-848c-a610f9f84ec2"), Type = TextBlockType.Text, Text = $"You have studied a specific terrain to overcome its challenges. Choose aquatic, arctic, desert, forest, mountain, plains, sky, swamp, or underground as your favored terrain. When in that terrain, you can ignore the effects of non-magical difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("7e67a763-5321-4a46-b6de-2a8ad5dd4833"), Type = TextBlockType.Text, Text = $"If you have the wild stride class feature, you gain a second benefit while in your favored terrain, depending on your choice." };
            yield return new TextBlock { Id = Guid.Parse("1b7e7ad0-83e1-4b38-a979-46558b1ba452"), Type = TextBlockType.Enumeration, Text = $" Aquatic: You gain a swim Speed equal to your Speed. If you already had a swim Speed, you gain a +10-foot status bonus to your swim Speed." };
            yield return new TextBlock { Id = Guid.Parse("1ad1a32a-8253-44ce-9818-26c13299990e"), Type = TextBlockType.Enumeration, Text = $" Arctic: You need to eat and drink only one-tenth as much as usual, you aren't affected by severe or extreme cold, and you can walk across ice and snow at full Speed without needing to {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("9657ccd8-96c2-45a4-8bba-e2005adbf8b5"), Type = TextBlockType.Enumeration, Text = $" Desert: You need to eat and drink only one-tenth as much as usual, you aren't affected by severe or extreme heat, and you can walk along sand at full Speed without needing to {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("2864c2f8-da8d-4323-9b59-9e1f78595abc"), Type = TextBlockType.Enumeration, Text = $" Forest, Mountain, or Underground: You gain a climb Speed equal to your Speed. If you already had a climb Speed, you gain a +10-foot status bonus to your climb Speed." };
            yield return new TextBlock { Id = Guid.Parse("39650a63-331c-4c55-8611-8ae5c7ab15f9"), Type = TextBlockType.Enumeration, Text = $" Plains: You gain a +10-foot status bonus to your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("2d06cc86-55e1-4590-b55d-4319a4cde113"), Type = TextBlockType.Enumeration, Text = $" Sky: You gain a +10-foot status bonus to your fly Speed, if you have one." };
            yield return new TextBlock { Id = Guid.Parse("9750f294-f1a4-4318-8608-0708f1dc420a"), Type = TextBlockType.Enumeration, Text = $" Swamp: You can move across bogs at full Speed, even if they are deep enough to be greater difficult terrain or to normally require you to {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("551a00b6-8daf-4b78-91c6-ac56559dc909"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
