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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A trace of draconic magic flows through your veins. Choose one cantrip from the arcane spell list. You can Cast this Spell as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. You gain the trained proficiency rank in arcane spell attack rolls and spell DCs, and your key spellcasting ability is Charisma." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnyInnateSpell(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID, spellLevel: 0);
            builder.GainSpecificSpellAttackProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
            builder.GainSpecificSpellcastingAbility(Guid.Parse(""), Stats.Instances.Charisma.ID);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
