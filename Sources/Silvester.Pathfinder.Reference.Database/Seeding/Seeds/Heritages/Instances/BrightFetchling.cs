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
    public class BrightFetchling : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Bright Fetchling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body proves that shadow can't exist without light. Perhaps your eyes glow brighter or your veins occasionally pulse with light. You emit dim light within 5 feet of you. You can activate or suppress this ability as an action, which has the concentrate trait. Additionally, you can force fragments of your shadow to glow and cast dancing lights and light as occult innate cantrips. Cantrips are heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You emit dim light within 5 feet of you. You can activate or suppress this ability as an action, which has the concentrate trait.");
            builder.GainSpecificInnateSpell(Guid.Parse(""), Spells.Instances.DancingLights.ID, MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificInnateSpell(Guid.Parse(""), Spells.Instances.Light.ID, MagicTraditions.Instances.Occult.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 85
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Fetchling.ID;
        }
    }
}
