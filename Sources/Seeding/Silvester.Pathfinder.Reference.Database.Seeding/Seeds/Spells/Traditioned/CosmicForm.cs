using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CosmicForm : Template
    {
        public static readonly Guid ID = Guid.Parse("0a9f8e85-3338-4bdf-80ab-6496b03b4d4f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cosmic Form",
                Level = 7,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c998317-62f2-47ed-818c-901850be2cbb"), Type = TextBlockType.Text, Text = "You recreate your form entirely out of cosmic energy, transforming into a Large battle form. You must have enough space to expand into, or the spell is lost. When you cast this spell, choose to take on the powers of the moon or the sun. You have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("a3e7d9f4-5435-4ac9-bf7a-3b6b5fdbb765"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of the form that you choose:" };
            yield return new TextBlock { Id = Guid.Parse("27226a93-05a1-4466-b38e-8600ff3df3af"), Type = TextBlockType.Enumeration, Text = "AC = 21 + your level. Ignore your armor check�s penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("15e4de51-98e5-4774-a66f-f3d369fabe56"), Type = TextBlockType.Enumeration, Text = "20 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("58ec0383-c1e0-4485-a7cb-0c163bd8dadd"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("b29d217c-b861-46e1-a920-ebce22ac094c"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you use. You�re trained with them. Your attack modifier is +25, and you use the listed damage. The melee attacks are Strength based (for the purpose of the enfeebled condition, for example), and the ranged attacks are Dexterity based. If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("eaf27207-7115-4217-a721-81cd66f6c751"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +25, unless your own is higher." };
            yield return new TextBlock { Id = Guid.Parse("afc987ee-10ec-41c4-bd67-b3ae30c25c35"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the stellar body:" };
            yield return new TextBlock { Id = Guid.Parse("02ddba0c-d0fe-4c1e-88d1-fef457f2f712"), Type = TextBlockType.Enumeration, Text = "Moon - Speed 30 feet, fly 50 feet; Melee [one-action] fist (agile, reach 10 feet), Damage 2d4+10 bludgeoning plus 1d6 fire; Ranged [one-action] moonbeam (range 90 feet), Damage 2d4+10 fire; this form�s fire damage is silver for resistances, weaknesses, and the like; on a critical hit with either Strike, the target is stupefied 2 for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("3028665a-25b0-48d8-a230-9014821fa4b5"), Type = TextBlockType.Enumeration, Text = "Sun - Speed 30 feet, fly 50 feet; Melee [one-action] fist (agile, reach 10 feet), Damage 2d6+10 fire plus 1d6 persistent fire; Ranged [one-action] sunbeam (range 90 feet), Damage 1d6+10 fire plus 1d6 persistent fire; on a critical hit with either Strike, the target is dazzled for 1 round." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8da27228-afc3-4991-9f70-a9942e5c442e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 97
            };
        }
    }
}
