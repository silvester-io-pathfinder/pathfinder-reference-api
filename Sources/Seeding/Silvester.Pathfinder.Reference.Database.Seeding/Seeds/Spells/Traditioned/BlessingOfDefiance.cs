using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlessingOfDefiance : Template
    {
        public static readonly Guid ID = Guid.Parse("7d2627e6-fe5e-48ed-b3ad-dd14e858c94f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blessing of Defiance",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "Varies.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e108264-d13e-4eb7-907b-04be0aa0b709"), Type = TextBlockType.Text, Text = "Channeling forth the power to persevere in the face of adversity, you grant the target the means to deny danger and avoid dire harm. Choose one saving throw: Fortitude, Reflex, or Will. The target gets a +4 status bonus to that saving throw for 1 round. The potency and number of targets of this blessing depend on how many actions you spend when Casting the Spell." };
            yield return new TextBlock { Id = Guid.Parse("d0f048d7-d318-48d9-9ff6-24633e2a7ba0"), Type = TextBlockType.Enumeration, Text = "[one-action] (somatic) The spell targets you or one willing ally within range." };
            yield return new TextBlock { Id = Guid.Parse("291ca293-783e-4405-afab-ee9d41189f7d"), Type = TextBlockType.Enumeration, Text = "[two-actions] (verbal) The spell targets you or one willing ally within range. If you choose Fortitude, the target gains resistance 15 to poison. If you choose Reflex, the target gains a +15-foot status bonus to its Speeds. If you choose Will, the target gains resistance 15 to mental damage." };
            yield return new TextBlock { Id = Guid.Parse("48b13dc1-644f-4f90-a352-321e9ebd2357"), Type = TextBlockType.Enumeration, Text = "[three-actions] (verbal) The spell targets you and all willing allies within 30 feet." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0e1f2af-75c6-419c-8e82-e5f677d25e4d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 91
            };
        }
    }
}
