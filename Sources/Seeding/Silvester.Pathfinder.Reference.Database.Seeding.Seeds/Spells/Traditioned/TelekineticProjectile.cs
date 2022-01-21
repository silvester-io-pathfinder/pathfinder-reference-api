using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TelekineticProjectile : Template
    {
        public static readonly Guid ID = Guid.Parse("ab61bcac-bdca-4fb7-825d-c0529831b049");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Telekinetic Projectile",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47f11264-dd44-4415-a93e-a32aa23b2eac"), Type = TextBlockType.Text, Text = "You hurl a loose, unattended object that is within range and that has 1 Bulk or less at the target. Make a spell attack roll against the target. If you hit, you deal bludgeoning, piercing, or slashing damage—as appropriate for the object you hurled—equal to 1d6 plus your spellcasting ability modifier. No specific traits or magic properties of the hurled item affect the attack or the damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b16db135-86f0-4a79-ba0e-947aa560bc48"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5660c6f5-96ee-482b-9a9e-912522704e00"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("7b44239f-8610-4de4-848b-2f372fd45c21"),
                CriticalSuccess = "You deal double damage.",
                Success = "You deal full damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b5f1da23-0241-477b-85db-50b9509d2522"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("7038987d-4fc2-4352-89f6-478e0f2fb267"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("b9e8fcaa-ec93-487d-acce-4c4a9403e80f"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a271dbb-998f-430e-91e2-dcb926af694f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
