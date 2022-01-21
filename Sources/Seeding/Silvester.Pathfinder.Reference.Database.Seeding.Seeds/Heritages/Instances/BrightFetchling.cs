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
        public static readonly Guid ID = Guid.Parse("e75995cc-0e93-4ea0-bf7a-81f7ea291de7");

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
            yield return new TextBlock { Id = Guid.Parse("63a2307b-26af-407a-83c2-0a8a806e59a4"), Type = TextBlockType.Text, Text = "Your body proves that shadow can't exist without light. Perhaps your eyes glow brighter or your veins occasionally pulse with light. You emit dim light within 5 feet of you. You can activate or suppress this ability as an action, which has the concentrate trait. Additionally, you can force fragments of your shadow to glow and cast dancing lights and light as occult innate cantrips. Cantrips are heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("36833821-0d3a-466d-ac16-ff0382300220"), "You emit dim light within 5 feet of you. You can activate or suppress this ability as an action, which has the concentrate trait.");
            builder.GainSpecificInnateSpell(Guid.Parse("a7d79848-5528-4af5-a8df-b5f5835bb6ac"), Spells.Instances.DancingLights.ID, MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificInnateSpell(Guid.Parse("086713b6-835e-4e6e-a051-d223c3f97ce0"), Spells.Instances.Light.ID, MagicTraditions.Instances.Occult.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1bbbc5d-4b0e-4645-876e-a16870c8f41b"),
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
