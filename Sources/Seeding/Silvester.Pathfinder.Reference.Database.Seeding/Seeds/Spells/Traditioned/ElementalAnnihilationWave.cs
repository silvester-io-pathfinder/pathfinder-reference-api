using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalAnnihilationWave : Template
    {
        public static readonly Guid ID = Guid.Parse("63f38c77-2a9a-47cf-bbf7-9cdf1af0aec3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Annihilation Wave",
                Level = 3,
                Area = "30-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("035161b1-8685-4c30-b94b-9f0992db63bd"), Type = TextBlockType.Text, Text = "You draw elemental power from your surroundings, and combining it with your own magical energy, unleash a wave of utter destruction and swirling colors that deals 1d6 fire damage and 3d6 bludgeoning damage with a basic Reflex save. The number of actions you spend when Casting this Spell determines the area and other parameters." };
            yield return new TextBlock { Id = Guid.Parse("fdc043c2-2d81-4849-a22d-3d5b495a8233"), Type = TextBlockType.Enumeration, Text = "[two-actions] (somatic, verbal) The spell is a 30-foot cone." };
            yield return new TextBlock { Id = Guid.Parse("8093ee5a-9964-4c15-84e8-ade48fff278b"), Type = TextBlockType.Enumeration, Text = "[three-actions] (material, somatic, verbal) The spell is a 30-foot cone. On a failed saving throw, creatures are pushed 5 feet away from you, and on a critical failure they are pushed 10 feet away and are knocked prone." };
            yield return new TextBlock { Id = Guid.Parse("388458fb-4283-49ee-9fa5-5c5d05752341"), Type = TextBlockType.Enumeration, Text = "Two Rounds If you spend 3 actions Casting the Spell, you can avoid finishing the spell and spend another 3 actions on your next turn to empower the spell even further. If you do, the spell is as 3 actions, but the area is a 60-foot cone, and for 1 round, the elements linger in the cone, racing off into the distance and making approaching you difficult, with the effects of gust of wind." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3eabfae0-b098-4c05-9e48-3f06d30f9f31"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("a4bade0b-ca64-44aa-b794-f2e72cbed636"), Type = TextBlockType.Text, Text = "The damage increases by 2d6, and the distance that enemies are pushed back if you spent 3 actions or 2 rounds increases by 5 feet on a failed save and 10 feet on a critical failure." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e154dbf-b478-4833-9e65-6bdbbdf3fe06"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 102
            };
        }
    }
}
