using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NatureIncarnate : Template
    {
        public static readonly Guid ID = Guid.Parse("79fa61d9-0d18-4e2f-90b2-bc7bea5af121");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nature Incarnate",
                Level = 10,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d296056-30ad-4438-859c-180323dc76fe"), Type = TextBlockType.Text, Text = "The primal power of the world flows through you. You transform into an incarnation of nature, either a green man or a kaiju. Your battle form is Medium for a green man or Gargantuan (30-foot-by-30-foot space) for a kaiju. You must have enough space to expand into or the spell is lost. While in this form, you gain the plant trait (for a green man) or the beast trait (for a kaiju). You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("0c2726e8-3d16-4a9e-8322-9e88cc19862d"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("c6145e7a-b870-474f-b15b-b6db5083f816"), Type = TextBlockType.Enumeration, Text = "AC = 25 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("90c8c3ea-3897-4923-be6b-3beae9ea60f2"), Type = TextBlockType.Enumeration, Text = "30 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("36a8edba-88b7-4136-9809-52ab5901ceea"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("b5b3aa04-9fe3-4443-b14b-1ae19a2c51e3"), Type = TextBlockType.Enumeration, Text = "One or more attacks specific to the battle form you choose, which are the only attacks you can use. You're trained with them. Your attack modifier is +34, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("dd79e694-87f7-4bd6-9ae3-bb2f62269016"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +36, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("8e633454-53cc-40ce-8787-cc6f8d18a464"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of incarnation you choose:" };
            yield return new TextBlock { Id = Guid.Parse("bc61c9e6-89e7-4f9d-a645-3438c92a988d"), Type = TextBlockType.Enumeration, Text = "Green Man - Speed 40 feet, climb Speed 40 feet; Melee [one‑action] vines (reach 30 feet, versatile P), Damage 6d8+12 bludgeoning; Ranged [one‑action] thorns (range 100 feet), Damage 6d6+6 piercing; Green Caress (aura, primal, transmutation) 60 feet. Enemies other than plants must succeed at a Fortitude save against your spell DC or become clumsy 1 for 1 round (clumsy 2 on a critical failure)." };
            yield return new TextBlock { Id = Guid.Parse("bee36d06-49f2-4710-acff-7ba60c265f24"), Type = TextBlockType.Enumeration, Text = "Kaiju - Speed 50 feet; resistance 5 to physical damage; Melee [one‑action] jaws (reach 30 feet), Damage 6d10+10 piercing; Melee [one‑action] claws (agile, reach 30 feet), Damage 6d8+8 slashing; Melee [one‑action] foot (agile, reach 15 feet), Damage 6d6+10 bludgeoning; Unstoppable You are immune to being immobilized and ignore difficult terrain and greater difficult terrain; Trample [three‑actions] You move up to double your Speed and move through the spaces of Huge or smaller creatures, trampling each creature whose space you enter. A trampled creature takes foot damage with a basic Reflex save against your spell DC." };
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
                Id = Guid.Parse("8042b33d-be3c-435d-887b-715ca04517e6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 354
            };
        }
    }
}
