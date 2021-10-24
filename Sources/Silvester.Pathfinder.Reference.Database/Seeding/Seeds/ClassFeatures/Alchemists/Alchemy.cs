using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class Alchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Alchemy", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You understand the complex interactions of natural and unnatural substances and can concoct alchemical items to meet your needs. You can do this using normal reagents and the Craft activity, or you can use special infused reagents that allow you to craft temporary items quickly and at no cost. Over time, you can create more and more alchemical items for free, and since each of them becomes more and more powerful, you advance in power dramatically, leaving behind those who don't understand your strange science." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the Alchemical Crafting feat, even if you don't meet that feat's prerequisites, and you gain the four common 1st-level alchemical formulas granted by that feat. Alchemical Items can be found here. You can use this feat to create alchemical items as long as you have the items' formulas in your formula book." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.DisableFeatPrerequisites(Guid.Parse(""), Feats.Instances.AlchemicalCrafting.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.AlchemicalCrafting.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.QuickAlchemy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 72
            };
        }
    }
}
