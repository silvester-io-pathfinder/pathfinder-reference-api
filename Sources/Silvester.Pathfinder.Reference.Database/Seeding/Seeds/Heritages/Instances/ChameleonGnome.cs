using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ChameleonGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("37a897ea-ac8a-407c-bf26-8443b948c8b3");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Chameleon Gnome"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The color of your hair and skin is mutable, possibly due to latent magic. You can slowly change the vibrancy and the exact color, and the coloration can be different across your body, allowing you to create patterns or other colorful designs. It takes a single action for minor localized shifts and up to an hour for dramatic shifts throughout your body. While you're asleep, the colors shift on their own in tune with your dreams, giving you an unusual coloration each morning. When you're in an area where your coloration is roughly similar to the environment (for instance, forest green in a forest), you can use the single action to make minor localized shifts designed to help you blend into your surroundings. This grants you a +2 circumstance bonus to Stealth checks until your surroundings shift in coloration or pattern." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "It takes a single action for minor localized shifts and up to an hour for dramatic shifts throughout your body.");
            builder.Manual(Guid.Parse(""), "When you're in an area where your coloration is roughly similar to the environment (for instance, forest green in a forest), you can use the single action to make minor localized shifts designed to help you blend into your surroundings. This grants you a +2 circumstance bonus to Stealth checks until your surroundings shift in coloration or pattern.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 43
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnome.ID;
        }
    }
}
