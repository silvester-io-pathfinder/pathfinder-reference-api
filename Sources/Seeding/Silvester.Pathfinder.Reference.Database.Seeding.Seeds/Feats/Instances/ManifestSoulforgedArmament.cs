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
    public class ManifestSoulforgedArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("ee565a18-cbbc-44f9-8ffe-16ccd2e5de36");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Manifest Soulforged Armament",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c042652-cfa4-44db-8533-80e555862e69"), Type = TextBlockType.Text, Text = $"You immediately wield or wear the soulforged armament bound to you. The soulforged armament remains manifested until you {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} this effect. Once per day when you use this ability, you can manifest the armament's essence form. You gain the armament's essence power until it's {ToMarkdownLink<Models.Entities.Action>("Dismissed", Actions.Instances.Dismiss.ID)}. After 1 minute, the essence form armament is automatically {ToMarkdownLink<Models.Entities.Action>("Dismissed", Actions.Instances.Dismiss.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3ce6729-66c2-48fb-a4d8-e1dea4801832"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
