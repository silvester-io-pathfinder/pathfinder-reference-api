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
    public class AdvancedWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("097fbd71-f459-4eed-917c-1eb698e78120");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Weaponry",
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
            yield return new TextBlock { Id = Guid.Parse("d5bcc2c1-cbba-48bf-9476-14ba958202c1"), Type = TextBlockType.Text, Text = $"Your eidolon's attack evolves. Choose one of your eidolon's starting melee unarmed attacks. It gains one of the following traits, chosen when you gain the feat: {ToMarkdownLink<Models.Entities.Trait>("disarm", Traits.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.Trait>("grapple", Traits.Instances.Grapple.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, {ToMarkdownLink<Models.Entities.Trait>("shove", Traits.Instances.Shove.ID)}, {ToMarkdownLink<Models.Entities.Trait>("trip", Traits.Instances.Trip.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("versatile bludgeoning", Traits.Instances.Versatile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("piercing", Traits.Instances.Versatile.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("slashing", Traits.Instances.Versatile.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afb53738-9a99-4062-b846-5d0d5caa3993"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
