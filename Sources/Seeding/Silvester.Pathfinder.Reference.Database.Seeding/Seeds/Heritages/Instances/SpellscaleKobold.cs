using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SpellscaleKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("6164ad33-f51f-497d-88e1-7dc54f90e8c8");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Spellscale Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c24e56cd-11df-4adb-96cf-d7cc1ccb6e98"), Type = TextBlockType.Text, Text = "A trace of draconic magic flows through your veins. Choose one cantrip from the arcane spell list. You can Cast this Spell as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. You gain the trained proficiency rank in arcane spell attack rolls and spell DCs, and your key spellcasting ability is Charisma." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse("1224687e-2cc3-4bf8-a8a3-2106c9c74020"), MagicTraditions.Instances.Arcane.ID, spellLevel: 0);
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("1e451bfe-e0cd-48ef-b611-87423de5c532"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("a5922649-c881-4e08-94d2-5cc971e0b2a9"), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellcastingAbility(Guid.Parse("6787ade4-a7dd-477e-b53d-5b721b5d662a"), Stats.Instances.Charisma.ID);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b11338cb-911a-4651-8936-34f3eb34a49f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 14
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
