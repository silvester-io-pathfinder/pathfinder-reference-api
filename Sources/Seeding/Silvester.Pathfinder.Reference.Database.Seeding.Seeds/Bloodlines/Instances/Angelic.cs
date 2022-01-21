using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Angelic : Template
    {
        public static readonly Guid ID = Guid.Parse("7428b938-285d-46bb-b121-99d7029bccbb");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Angelic",
                BloodMagic = "An angelic aura protects you or one target, granting a +1 status bonus to saving throws for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.AngelicHalo.ID,
                AdvancedBloodlineSpellId = Spells.Instances.AngelicWings.ID,
                GreaterBloodlineSpellId = Spells.Instances.CelestialBrand.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f555e3b2-b41d-47e1-8df2-16685cacdd72"), Type = TextBlockType.Text, Text = "One of your forebears hailed from a celestial realm, or your ancestors� devotion led to their lineage being blessed." };
        }
        
        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("d3c28efc-0f85-4edd-98af-0f9647fd788b"), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("e0ea318c-f1cd-4978-aebb-2db21ad1762e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("cc0c6967-8873-4d34-8de7-89fb20ec13fc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse("39b83043-61c5-4eaa-a9cd-2d552ab97c8d"), Spells.Instances.AngelicHalo.ID);
            builder.GainSpecificSpell(Guid.Parse("ba557109-00c2-40d7-a8ec-11ac73b2884d"), Spells.Instances.Light.ID);
            builder.GainSpecificSpell(Guid.Parse("c5641a8e-8366-424e-a503-c32eba71d274"), Spells.Instances.Heal.ID);
            builder.GainSpecificSpell(Guid.Parse("9a4ae12c-120e-481f-9c91-d9138915a4d8"), Spells.Instances.SpiritualWeapon.ID);
            builder.GainSpecificSpell(Guid.Parse("5c9b757d-87a4-40f2-a62d-7795d8f06d11"), Spells.Instances.SearingLight.ID);
            builder.GainSpecificSpell(Guid.Parse("f69a1782-5bfe-4415-840c-c56098bcfa3f"), Spells.Instances.DivineWrath.ID);
            builder.GainSpecificSpell(Guid.Parse("b0e3c3d1-c30c-4746-8e3a-4f6e24f003de"), Spells.Instances.FlameStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("75b16f98-1465-483a-a262-816a6429b4f8"), Spells.Instances.BladeBarrier.ID);
            builder.GainSpecificSpell(Guid.Parse("edeb224f-bd61-47a5-a7db-122b058e8f38"), Spells.Instances.DivineDecree.ID);
            builder.GainSpecificSpell(Guid.Parse("68bb014f-2083-4f09-8f1c-948b48281e12"), Spells.Instances.DivineAura.ID);
            builder.GainSpecificSpell(Guid.Parse("3d078175-9486-4652-a5ad-af2dd5fe073f"), Spells.Instances.Foresight.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
            yield return Skills.Instances.Religion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0817268-03f0-44af-9646-b70988c6c024"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 195
            };
        }
    }
}
