using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoulforgerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e8e43792-7694-4471-adb1-97b94e9e4483");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soulforger Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat before gaining two other feats from this archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5b782f3-1ff8-41cf-8421-8401d7ed0435"), Type = TextBlockType.Text, Text = "You can manifest the power of your spirit in combat to realize your motivations. You manifest an armor, shield, or weapon as a soulforged armament. Choose one essence power for the armament. It gains the power temporarily when you manifest its essence form. Each power has a corruption flaw that affects you if you have soulforged corruption. Essence powers that only apply to some types of armament indicate which. Changing an essence power requires 1 week of retraining, and you can’t retrain it while you have soulforged corruption." };
            yield return new TextBlock { Id = Guid.Parse("d31523f2-e777-49a1-a0fc-ffa584395b9c"), Type = TextBlockType.Text, Text = "You can (feat: Manifest Soulforged Armament) to summon your armaments in combat." };
            yield return new TextBlock { Id = Guid.Parse("a54b631a-c6a0-4c9a-9a60-1a5eda8dc21c"), Type = TextBlockType.Text, Text = "__Add the chosen essence power to your soulforged armament manually.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("2183bc79-73c8-431f-9831-6f75e0d5406a"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("e0881ce9-4c58-4d23-a700-d46c7d153d43"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
                or.HaveSpecificMagicTradition(Guid.Parse("48447e95-cfa0-47aa-b570-cdd70e0c5075"), MagicTraditions.Instances.Divine.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18f3a2d9-e477-466f-82f5-7f833d088cf5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
