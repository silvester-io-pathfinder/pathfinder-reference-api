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
    public class FeyTouchedGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("6820eb19-bb58-4d56-9fdf-ce57f72b75d6");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Fey-Touched Gnome"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ad814182-94f4-4ca4-a568-1326f65a1e33"), Type = TextBlockType.Text, Text = "The blood of the fey is so strong within you that you're truly one of them. You gain the fey trait, in addition to the gnome and humanoid traits. Choose one cantrip from the primal spell list. You can cast this spell as a primal innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. You can change this cantrip to a different one from the same list once per day by meditating to realign yourself with the First World; this is a 10-minute activity that has the concentrate trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("610ff5c6-dfb1-4b41-8efb-d6954f8a3a89"), Traits.Instances.Fey.ID);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("09148d11-0419-4f30-b585-dfd43fa9428d"), MagicTraditions.Instances.Primal.ID, spellLevel: 0);
            //TODO: Add the daily preparation part.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97b5a8c8-6f10-4ae4-878a-c8619ab3c6fb"),
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
