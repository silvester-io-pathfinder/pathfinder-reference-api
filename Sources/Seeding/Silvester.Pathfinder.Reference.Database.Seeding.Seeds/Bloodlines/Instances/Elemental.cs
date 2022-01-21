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
    public class Elemental : Template
    {
        public static readonly Guid ID = Guid.Parse("f3a02677-d33b-4d85-abcd-08ec68745f6f");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Elemental",
                BloodMagic = "Elemental energy surrounds you or a target. Either you gain a +1 status bonus to Intimidation checks for 1 round, or a target takes 1 damage per spell level. The damage is bludgeoning or fire, according to your elemental type (see below). If the spell already deals that type of damage, combine it with the spell�s initial damage before determining weaknesses and resistances.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.ElementalToss.ID,
                AdvancedBloodlineSpellId = Spells.Instances.ElementalMotion.ID,
                GreaterBloodlineSpellId = Spells.Instances.ElementalBlast.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("47b4a05c-a582-4223-960c-1bb92b105bd6"), Type = TextBlockType.Text, Text = "A genie ancestor or some other elemental influence has imbued your blood with primal fury, affecting how the bloodline spells and granted spells, as well as your blood magic, function." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("73e584d3-5f8c-4365-9e45-6d41930b0fdb"), Type = TextBlockType.Text, Text = "Choose the type of elemental that influenced your bloodline: air, earth, fire, or water. If your element is air, you buffet your foes with powerful winds; if it's earth, you toss huge chunks of rock; if it's fire, you incinerate your foes with flame; and if it's water, you inundate your foes with torrents of water. For fire, all marked spells deal fire damage. For other elements, they deal bludgeoning damage. You replace any existing elemental traits with the trait of the element you chose." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("dcce6733-31ee-4834-a526-d958663dbd52"), MagicTraditions.Instances.Primal.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("6d8af8b3-9d34-4eea-9b00-23733102120d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("2771287a-89c9-48b3-8e20-f30c830f46d2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse("29173ab1-a6d8-421f-b22f-77f344dfd59a"), Spells.Instances.ElementalToss.ID);
            builder.GainSpecificSpell(Guid.Parse("adaf59c4-9ee0-4c1e-adf7-b6ac87d2cf2e"), Spells.Instances.ProduceFlame.ID);
            builder.GainSpecificSpell(Guid.Parse("26e5e9bc-16d6-42bf-a2de-72854d66818f"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("672c6e74-f59e-4556-a766-dc7f9e8a5988"), Spells.Instances.ResistEnergy.ID);
            builder.GainSpecificSpell(Guid.Parse("bbd7befc-3747-4f3d-bd9a-a1702a0cf7b0"), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse("7fb007fa-ebe2-4d3c-87fc-c7089add42df"), Spells.Instances.FreedomOfMovement.ID);
            builder.GainSpecificSpell(Guid.Parse("7bf1b07b-d466-4e4e-a860-556b054483a9"), Spells.Instances.ElementalForm.ID);
            builder.GainSpecificSpell(Guid.Parse("e28ecda1-4efc-428f-9d9f-ba337469ed76"), Spells.Instances.Repulsion.ID);
            builder.GainSpecificSpell(Guid.Parse("b4b09a4f-6df1-41fa-aad1-9e330f6c9173"), Spells.Instances.EnergyAegis.ID);
            builder.GainSpecificSpell(Guid.Parse("c4557797-99b5-4bc9-b609-83bcf11a990c"), Spells.Instances.PrismaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse("d09d2906-fa99-4e43-948f-8d2890a658b5"), Spells.Instances.StormOfVengeance.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8402cd4c-3ef7-4d42-9cf4-c930a34059a5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 196
            };
        }
    }
}
