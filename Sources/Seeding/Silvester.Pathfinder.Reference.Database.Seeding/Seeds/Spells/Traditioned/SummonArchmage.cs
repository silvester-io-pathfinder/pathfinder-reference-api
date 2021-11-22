using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonArchmage : Template
    {
        public static readonly Guid ID = Guid.Parse("efe033e2-dab9-456b-a60a-0e3cda187acb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Archmage",
                Level = 8,
                Range = "100 feet.",
                Duration = "Until the end of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db551bcb-6807-49a1-a66a-9f445116a732"), Type = TextBlockType.Text, Text = "You briefly call forth the spirit of a legendary wizard from ages long past, which manifests as an immense humanoid figure (typically an elf or a human). The archmage occupies the space of a Large creature and has a Speed of 60 feet." };
            yield return new TextBlock { Id = Guid.Parse("189ddb16-9069-4cce-841e-5f72e2ba2ea7"), Type = TextBlockType.Enumeration, Text = "Arrive (evocation, force) Archmage�s Amplification The archmage arrives in a fierce burst of magical force, automatically dealing 3d4+3 force damage to up to 5 creatures it chooses within 100 feet of it. Like magic missiles, this can be blocked by the shield spell." };
            yield return new TextBlock { Id = Guid.Parse("a868e337-4b07-430e-955f-6efdfe69a40a"), Type = TextBlockType.Text, Text = "The archmage also feeds magical power into some spells. Beneficial spells last longer due to the archmage�s influence. When the remaining duration of a beneficial spell affecting you or one of your allies would decrease (usually at the start of the caster�s turn), it doesn�t decrease if the subject of the spell is within 100 feet of the archmage. This applies only if the spell�s maximum duration was 3 rounds or longer." };
            yield return new TextBlock { Id = Guid.Parse("e71b7782-195b-422e-b6a2-e634722fcef0"), Type = TextBlockType.Enumeration, Text = "Depart (abjuration) Archmage�s Rebuke The archmage drains the magic from your foes. Each of your enemies within 100 feet of the archmage must attempt a Will save. On a failure, the creature is stupefied 2 for 1 round, and if it�s currently benefiting from any spells of a lower level than summon archmage, the archmage can choose any one of them and end the spell." };
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Incarnate.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09ce867d-0884-4171-b7d5-cb3e6bdd61eb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 131
            };
        }
    }
}
