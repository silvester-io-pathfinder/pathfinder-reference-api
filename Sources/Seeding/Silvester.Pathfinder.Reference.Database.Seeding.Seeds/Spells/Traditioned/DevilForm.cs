using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DevilForm : Template
    {
        public static readonly Guid ID = Guid.Parse("e465037b-5282-4fef-89c8-23637c7bc762");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Devil Form",
                Level = 6,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("456ead7e-d564-4059-9de8-55a70e2403e2"), Type = TextBlockType.Text, Text = "You bind yourself to the power of Hell, transforming into a Medium devil battle form. When you cast this spell, choose barbazu, erinys, osyluth, or sarglagon. If you choose osyluth or sarglagon, the battle form is Large and you must have enough space to expand into or the spell is lost. While in this form you gain the devil and fiend traits. You have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("f5515e61-9436-417a-9c5c-2c251c7e95d6"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of the form that you choose:" };
            yield return new TextBlock { Id = Guid.Parse("a4a02dec-83e5-4eac-af5c-c6b3faf12eb3"), Type = TextBlockType.Enumeration, Text = "AC = 22 + your level. Ignore your armor check�s penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("f2bdda82-3fd6-4eb1-9e38-547f80b02bc3"), Type = TextBlockType.Enumeration, Text = "5 temporary Hit Points, resistance 5 to physical damage (except silver), and weakness 5 to good." };
            yield return new TextBlock { Id = Guid.Parse("13b2eefc-bbdf-48a4-833e-64ac6d1cc0ce"), Type = TextBlockType.Enumeration, Text = "Resistance 10 to fire." };
            yield return new TextBlock { Id = Guid.Parse("b55a19ce-aba7-48a8-80e1-2c186f05df5c"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("e43d9910-51b2-447a-a973-c3a541e801d5"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you use. You�re trained with them. Your attack modifier is +20, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your attack modifier is higher for the given unarmed attack or weapon, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("4a53cbd6-e441-4ec1-8d55-fde96194222b"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +23, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("6df4122a-4da7-4af0-be54-d98e480e8fd4"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of devil you choose:" };
            yield return new TextBlock { Id = Guid.Parse("87575329-11a1-47f2-91a4-e81a862527c0"), Type = TextBlockType.Enumeration, Text = "Barbazu - Speed 35 feet; Melee [one-action] glaive (deadly d8, forceful, reach 10 feet), Damage 2d8+10 slashing plus 1d6 evil and 1d6 persistent bleed; Melee [one-action] beard, Damage 3d8 piercing plus 1d6 evil; Melee [one-action] claw (agile), Damage 3d6 slashing plus 1d6 evil." };
            yield return new TextBlock { Id = Guid.Parse("cb470767-1d2d-4076-855e-c177942dfb66"), Type = TextBlockType.Enumeration, Text = "Erinys - Speed 25 feet, fly 40 feet; Melee [one-action] longsword (versatile P), Damage 1d8+10 slashing plus 1d6 evil and 1d6 fire; Ranged [one-action] composite longbow (deadly d10, range increment 100 feet, volley), Damage 1d8 piercing plus 1d6 evil and 1d6 fire." };
            yield return new TextBlock { Id = Guid.Parse("717c3eca-41b4-41b5-a299-47910f413056"), Type = TextBlockType.Enumeration, Text = "Osyluth - Speed 35 feet, fly 30 feet; Melee [one-action] jaws, Damage 2d10+10 piercing plus 1d6 evil; Melee [one-action] claw (agile, reach 10 feet), Damage 2d6 slashing plus 1d6 evil; Melee [one-action] stinger (reach 15 feet), Damage 1d10 piercing plus 1d6 evil and 1d6 poison; Ranged [one-action] bone shard (range increment 30 feet), Damage 2d6 piercing plus 1d6 evil." };
            yield return new TextBlock { Id = Guid.Parse("8d677e31-549b-4a47-a0d8-22516b15a4eb"), Type = TextBlockType.Enumeration, Text = "Sarglagon - Speed 25 feet, fly 25 feet, swim 30 feet; Melee [one-action] fangs, Damage 2d10+10 piercing plus 1d6 evil; Melee [one-action] tentacle arm (agile), Damage 1d8 bludgeoning plus 1d6 evil and 1d6 poison." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ea7a8f70-dade-443f-920c-40d39943e5b0"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("04e9e7fb-a144-4958-b255-efeeb215a52b"), Traits.Instances.Lawful.ID);
            builder.Add(Guid.Parse("277a4dfc-2786-4a12-aa23-cb139e0ac120"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("ffd094c2-68eb-4088-96a2-ff2613a6554d"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bf6bd17-f02c-4410-9117-13e5702f3dc4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 99
            };
        }
    }
}
