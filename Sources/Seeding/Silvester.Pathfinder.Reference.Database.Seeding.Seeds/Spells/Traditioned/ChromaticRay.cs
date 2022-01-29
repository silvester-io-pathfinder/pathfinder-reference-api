using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChromaticRay : Template
    {
        public static readonly Guid ID = Guid.Parse("ed7646bd-a8ed-4b74-bafb-2dc84370f2bd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chromatic Ray",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7efa83c-2aa2-4fb2-9f1d-bd1571e2ad69"), Type = TextBlockType.Text, Text = "You send out a ray of colored light streaming toward your enemy, with a magical effect depending on the ray's color. Make a spell attack roll. If you hit, roll 1d4 to see which beam you cast. If the ray deals damage, that damage is doubled on a critical hit. Any additional traits that apply to a ray are listed in parentheses just after the name of the color." };
            yield return new TextBlock { Id = Guid.Parse("487f42fa-ff7e-4be3-9947-397d1c6ac58b"), Type = TextBlockType.Enumeration, Text = "1. Red (fire) - The ray deals 30 fire damage to the target." };
            yield return new TextBlock { Id = Guid.Parse("cdbeda0e-a8f4-4cc5-9804-066875709430"), Type = TextBlockType.Enumeration, Text = "2. Orange (acid) - The ray deals 40 acid damage to the target." };
            yield return new TextBlock { Id = Guid.Parse("fefe4f9b-9c2b-488d-bb42-660f8e053f70"), Type = TextBlockType.Enumeration, Text = "3. Yellow (electricity) - The ray deals 50 electricity damage to the target." };
            yield return new TextBlock { Id = Guid.Parse("3d9dd687-f3aa-4d10-ba0e-f0ef25eef22f"), Type = TextBlockType.Enumeration, Text = "4. Green (poison) - The ray deals 25 poison damage to the target, and the target must succeed at a Fortitude save or be enfeebled 1 for 1 minute (enfeebled 2 on a critical failure)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0c640fc4-12ad-4c6e-bcac-3e2d0237a418"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b73f1aa2-c266-4484-8361-818f8a1e106e"), Type = TextBlockType.Text, Text = "The damage for red, orange, yellow, and green each increase by 10. Roll 1d8 to determine the ray's color, using the results for 1-4 above and the results for 5-8 below." },
                    new TextBlock {Id = Guid.Parse("fd6044c2-66d6-40f6-ac72-ea40c5a956b3"), Type = TextBlockType.Enumeration, Text = "5. Blue - The ray has the effect of the flesh to stone spell. On a critical hit, the target is clumsy 1 as long as it's slowed by the flesh to stone effect." },
                    new TextBlock {Id = Guid.Parse("1e702451-9f6f-4e57-a742-d6487d82ec28"), Type = TextBlockType.Enumeration, Text = "6. Indigo (emotion, incapacitation, mental) - The ray has the effect of the confusion spell. On a critical hit, it has the effect of warp mind instead." },
                    new TextBlock {Id = Guid.Parse("15f67f2d-38ce-4c87-a960-69301391ef2f"), Type = TextBlockType.Enumeration, Text = "7. Violet - The target is slowed for 1 minute. It must also succeed at a Will save or be teleported 120 feet directly away from you (if there isn't room for it to appear there, it appears in the nearest open space); this is a teleportation effect." },
                    new TextBlock {Id = Guid.Parse("eb4ab37f-3cc2-4128-95b0-bce13ded3d2f"), Type = TextBlockType.Enumeration, Text = "8. Intense Color - The target is dazzled until the end of your next turn, or blinded if your attack roll was a critical hit. Roll again and add the effects of another color (rerolling results of 8)." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("73a117d0-0799-4931-bd2e-8e6f47581760"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("18041a50-6a9a-4597-b792-b977229f06c6"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("3aedd75f-7a40-477c-b1e0-bcd001ef3858"), Traits.Instances.Light.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a67487e-ff46-416e-a858-c699075f3f26"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 95
            };
        }
    }
}
