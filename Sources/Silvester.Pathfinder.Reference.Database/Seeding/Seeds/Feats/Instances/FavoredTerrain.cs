using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FavoredTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("d26d0abc-e0c7-4627-9c9c-00a8b88a02ab");

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
            yield return new TextBlock { Id = Guid.Parse("74827fad-29e4-465b-9f5e-bf98f11e7b50"), Type = TextBlockType.Text, Text = "You have studied a specific terrain to overcome its challenges. Choose aquatic, arctic, desert, forest, mountain, plains, sky, swamp, or underground as your favored terrain. When in that terrain, you can ignore the effects of non-magical difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("45859e3b-8423-4f61-b865-d98e6bdb7aa0"), Type = TextBlockType.Text, Text = "If you have the wild stride class feature, you gain a second benefit while in your favored terrain, depending on your choice." };
            yield return new TextBlock { Id = Guid.Parse("a2fbb401-732a-4eb4-bd55-1326b420a012"), Type = TextBlockType.Enumeration, Text = " Aquatic: You gain a swim Speed equal to your Speed. If you already had a swim Speed, you gain a +10-foot status bonus to your swim Speed." };
            yield return new TextBlock { Id = Guid.Parse("227a7de5-cb9b-4abf-8b45-3d843291fb02"), Type = TextBlockType.Enumeration, Text = " Arctic: You need to eat and drink only one-tenth as much as usual, you aren’t affected by severe or extreme cold, and you can walk across ice and snow at full Speed without needing to (action: Balance)." };
            yield return new TextBlock { Id = Guid.Parse("ff832f3f-9395-42fb-a080-c9d4dcf48f68"), Type = TextBlockType.Enumeration, Text = " Desert: You need to eat and drink only one-tenth as much as usual, you aren’t affected by severe or extreme heat, and you can walk along sand at full Speed without needing to (action: Balance)." };
            yield return new TextBlock { Id = Guid.Parse("330946ed-ae4e-4276-b6c5-e782c1b156d4"), Type = TextBlockType.Enumeration, Text = " Forest, Mountain, or Underground: You gain a climb Speed equal to your Speed. If you already had a climb Speed, you gain a +10-foot status bonus to your climb Speed." };
            yield return new TextBlock { Id = Guid.Parse("05d46974-363b-4516-9b21-3fdb09311b92"), Type = TextBlockType.Enumeration, Text = " Plains: You gain a +10-foot status bonus to your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("59acff57-2b7e-4b2e-b2e2-4541ff302465"), Type = TextBlockType.Enumeration, Text = " Sky: You gain a +10-foot status bonus to your fly Speed, if you have one." };
            yield return new TextBlock { Id = Guid.Parse("266daa58-c083-4460-b929-aedad665825d"), Type = TextBlockType.Enumeration, Text = " Swamp: You can move across bogs at full Speed, even if they are deep enough to be greater difficult terrain or to normally require you to (action: Swim)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8126b65a-6f52-4ab9-a8a6-49369cf539d2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
