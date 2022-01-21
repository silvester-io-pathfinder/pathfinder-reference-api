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
    public class WellspringGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("f574f17b-2c71-4a9e-adba-a91a5f5f6e22");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Wellspring Gnome"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7c3c3cfa-244d-4b5a-8858-85f60c0f9a4b"), Type = TextBlockType.Text, Text = "Some other source of magic has a greater hold on you than the primal magic of your fey lineage does. This connection might come from an occult plane or an ancient occult song; a deity, celestial, or fiend; magical effluent left behind by a mage war; or ancient rune magic." };
            yield return new TextBlock { Id = Guid.Parse("56247009-b230-4c67-a4c9-d6588391ced0"), Type = TextBlockType.Text, Text = "Choose arcane, divine, or occult. You gain one cantrip from that magical tradition's spell list. You can cast this spell as an innate spell at will, as a spell of your chosen tradition. A cantrip is heightened to a spell level equal to half your level rounded up. Whenever you gain a primal innate spell from a gnome ancestry feat, change its tradition from primal to your chosen tradition." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("c46792db-4d42-4c1b-9a57-f877a55c19d7"), or => 
            {
                or.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("548b8567-7292-4006-a5bd-b8927e107b72"), MagicTraditions.Instances.Arcane.ID, spellLevel: 0);
                or.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("e2410497-e18a-4301-b13e-01b1f1cf6057"), MagicTraditions.Instances.Divine.ID, spellLevel: 0);
                or.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("4a135938-376f-4936-8e79-c3bb49222957"), MagicTraditions.Instances.Occult.ID, spellLevel: 0);
            });

            builder.Manual(Guid.Parse("257829f5-74e6-40f8-971d-881d122d1fdb"), "Whenever you gain a primal innate spell from a gnome ancestry feat, change its tradition from primal to your chosen tradition.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1996025-c5b8-43c1-a86e-22fb2d9dcba3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 44
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnome.ID;
        }
    }
}
