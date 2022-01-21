using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("66496723-8f60-4b1d-a1c3-4236ea63b4d3"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("9d0d1367-db54-43f0-adeb-663913960c61"), TraitId = Traits.Instances.Evocation.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("ed609e11-dbdd-4cf2-ad48-3b755363164b"), TraitId = Traits.Instances.Force.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("a16ea447-ea8e-4b81-926d-d2d9cb8b2d6d"), Type = TextBlockType.Heading, Text = "Archmage's Amplification" },
                    new TextBlock { Id = Guid.Parse("d4561d6b-71b9-4286-82b9-f048b5790381"), Type = TextBlockType.Text, Text = "The archmage arrives in a fierce burst of magical force, automatically dealing 3d4+3 force damage to up to 5 creatures it chooses within 100 feet of it. Like magic missiles, this can be blocked by the shield spell." },
                    new TextBlock { Id = Guid.Parse("478ec9be-6728-4b28-9102-4172cce5ad85"), Type = TextBlockType.Text, Text = "The archmage also feeds magical power into some spells. Beneficial spells last longer due to the archmage's influence. When the remaining duration of a beneficial spell affecting you or one of your allies would decrease (usually at the start of the caster's turn), it doesn't decrease if the subject of the spell is within 100 feet of the archmage. This applies only if the spell's maximum duration was 3 rounds or longer." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("e235dd30-2816-42b7-b7a6-5a2b898cff9a"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("367de64d-027b-4fe0-8ab3-c6d33a49a689"), TraitId = Traits.Instances.Abjuration.ID }
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("ba1e0a06-e45d-4b3e-a9e2-1cc7df756bd1"), Type = TextBlockType.Heading, Text = "Archmage's Rebuke " },
                    new TextBlock { Id = Guid.Parse("c44fbc61-c675-4593-aa74-4d228dea3e30"), Type = TextBlockType.Text, Text = "The archmage drains the magic from your foes. Each of your enemies within 100 feet of the archmage must attempt a Will save. On a failure, the creature is stupefied 2 for 1 round, and if it's currently benefiting from any spells of a lower level than summon archmage, the archmage can choose any one of them and end the spell." },
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
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("622ddc6c-d82b-4278-9f21-9ffa0a73e804"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("78054b6f-bd56-4b55-b874-07eb38c5155e"), Traits.Instances.Incarnate.ID);
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
