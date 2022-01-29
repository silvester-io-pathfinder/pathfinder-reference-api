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
    public class SoulforgerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("51f04aa0-ff25-4466-acc8-9ce8947d89ac");

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
            yield return new TextBlock { Id = Guid.Parse("0b9931e8-c60c-4e66-95c2-5b33bc732060"), Type = TextBlockType.Text, Text = $"You can manifest the power of your spirit in combat to realize your motivations. You manifest an armor, shield, or weapon as a soulforged armament. Choose one essence power for the armament. It gains the power temporarily when you manifest its essence form. Each power has a corruption flaw that affects you if you have soulforged corruption. Essence powers that only apply to some types of armament indicate which. Changing an essence power requires 1 week of retraining, and you can't retrain it while you have soulforged corruption." };
            yield return new TextBlock { Id = Guid.Parse("34eeaf47-5dd2-4304-a877-d3f175e0cc23"), Type = TextBlockType.Text, Text = $"You can {ToMarkdownLink<Models.Entities.Feat>("Manifest Soulforged Armament", Feats.Instances.ManifestSoulforgedArmament.ID)} to summon your armaments in combat." };
            yield return new TextBlock { Id = Guid.Parse("e9fd3ec7-ac8a-476c-af5a-c7fd8979853e"), Type = TextBlockType.Text, Text = $"__Add the chosen essence power to your soulforged armament manually.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c92827ff-36be-44b7-a80b-f1619a233c86"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("ca3f0c64-009a-4a72-90b4-a4ba50c64307"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
                or.HaveSpecificMagicTradition(Guid.Parse("04766a5b-b8e9-46d2-958e-99c2155a8cfc"), MagicTraditions.Instances.Divine.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce31d2de-1353-47f9-8521-86d2dd8ddd4b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
