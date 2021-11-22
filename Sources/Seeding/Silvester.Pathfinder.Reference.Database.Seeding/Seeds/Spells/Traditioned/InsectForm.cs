using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InsectForm : Template
    {
        public static readonly Guid ID = Guid.Parse("faee97be-896d-4f90-ac8d-7b62a6f67767");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Insect Form",
                Level = 3,
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a8f3bcc-4061-464c-9641-325e44ed2d29"), Type = TextBlockType.Text, Text = "You envision a simple bug and transform into a Medium animal battle form. When you cast this spell, choose ant, beetle, centipede, mantis, scorpion, or spider. You can decide the specific type of animal (such as such as a ladybug or scarab for beetle), but this has no effect on the form's Size or statistics. While in this form, you gain the animal trait. You can Dismiss this spell." };
            yield return new TextBlock { Id = Guid.Parse("4b9726a2-e3aa-4427-9a04-3b6e00919145"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("ab060a35-3548-4252-9832-0d39fd62c27b"), Type = TextBlockType.Enumeration, Text = "AC = 18 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("460c6749-007f-4c19-ab8d-832e25bd6ecc"), Type = TextBlockType.Enumeration, Text = "10 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("e2c85dfe-6eb4-43d2-b57b-0aeb38aeee45"), Type = TextBlockType.Enumeration, Text = "Low-light vision." };
            yield return new TextBlock { Id = Guid.Parse("1110786e-2e86-40f3-89de-b04391623a6c"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you choose, which are the only attacks you can use. You're trained with them. Your attack modifier is +13, and your damage bonus is +2. These attacks are Strength based (for the purpose of the enfeebled condition). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("231555a6-aceb-4337-8dde-216968d989ef"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +13, unless your own is higher." };
            yield return new TextBlock { Id = Guid.Parse("0ce9ab24-b192-489e-ae3b-65b59df128b2"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("3f418231-5dea-4e92-b4b3-7276e287164e"), Type = TextBlockType.Enumeration, Text = "Ant - Speed 30 feet, climb Speed 30 feet; Melee [one-action] mandibles, Damage 2d6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("0ad86451-8dc7-4cff-939a-dc9212d18fa0"), Type = TextBlockType.Enumeration, Text = "Beetle - Speed 25 feet; Melee [one-action] mandibles, Damage 2d10 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("dd27287c-8c69-4501-822b-93e4ce45c962"), Type = TextBlockType.Enumeration, Text = "Centipede - Speed 25 feet, climb Speed 25 feet; darkvision; Melee [one-action] mandibles, Damage 1d8 piercing plus 1d4 persistent poison." };
            yield return new TextBlock { Id = Guid.Parse("574bcc50-d89b-4bcf-8b3a-3e99275a3aaf"), Type = TextBlockType.Enumeration, Text = "Mantis - Speed 40 feet; imprecise scent 30 feet; Melee [one-action] foreleg, Damage 2d8 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("73690b19-0ada-4c27-a16f-31f4d09e1794"), Type = TextBlockType.Enumeration, Text = "Scorpion - Speed 40 feet; darkvision, imprecise tremorsense 60 feet; Melee [one-action] stinger, Damage 1d8 piercing plus 1d4 persistent poison; Melee [one-action] pincer (agile), Damage 1d6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("5d7aea58-e3dc-46c6-ada0-ff46b112450c"), Type = TextBlockType.Enumeration, Text = "Spider - Speed 25 feet, climb Speed 25 feet; darkvision; Melee [one-action] fangs, Damage 1d6 piercing plus 1d4 persistent poison; Ranged [one-action] web (range increment 20 feet), Damage entangles the target for 1 round." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d043fdc9-cb8d-4035-89fe-8a8715034fcc"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("326b418c-ec27-4d2b-bfe2-883723ae6b00"), Type = TextBlockType.Text, Text = "Your battle form is Large, and your attacks have 10-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 15 temporary HP, attack modifier +16, damage bonus +6, and Athletics +16." }
                }
            }; 
            
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b1685caf-8a43-47f9-aeea-f7ab49a6562e"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4220c8fd-5ad7-43b2-9a97-58c0da2f6282"), Type = TextBlockType.Text, Text = "Your battle form is Huge, and your attacks have 15-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 20 temporary HP, attack modifier +18, damage bonus +2 and double damage dice (including persistent damage), and Athletics +20." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10270cc9-a885-4161-bc8f-01858d856e5d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 346
            };
        }
    }
}
