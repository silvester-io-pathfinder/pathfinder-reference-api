using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowRaid : Template
    {
        public static readonly Guid ID = Guid.Parse("28802ae8-7010-4253-b4ee-bcebdf885283");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Raid",
                Level = 7,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "30-foot burst.",
                Addendum = "Saving throw can be Reflex or Will (target's choice).",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc31633c-2330-4de1-899b-559a90d3eb0e"), Type = TextBlockType.Text, Text = "You spin illusions of flying shadows throughout the area. The shadows strike and cavort, harming your foes and blocking their vision with twisting shadow. Enemies in the area when you Cast the Spell take 6d8 bludgeoning, piercing, or slashing damage, with a basic Reflex or Will save, as shadows explode into being. You choose the damage type when you Cast the Spell, and each creature chooses the type of save it attempts before it rolls the save. The shadows then persist in the area for 1 minute, dealing 3d8 damage of the type you chose to any enemy that ends its turn in the area. All creatures are concealed to enemies in the area, as the illusory shadows swarm over them and block light." };
            yield return new TextBlock { Id = Guid.Parse("5432b2ea-35e5-43d2-8dd9-8c9310bdef6c"), Type = TextBlockType.Text, Text = "A creature that spends an action to Seek or otherwise interact with the shadow raid can attempt a Perception check to disbelieve it. On a success, the creature halves the damage it takes from the shadows, and the shadows no longer impede its vision. These benefits last until the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("20ab4c51-c1af-437c-9588-6a89f04c95c8"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("29480b41-a85d-4d1d-9045-6ab622a796a5"), Type = TextBlockType.Text, Text = "The initial damage increases by 2d8, and the damage to a creature that ends its turn in the area increases by 1d8." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Shadow.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea7cc9cd-a336-4a68-abf9-9784a35df326"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 129
            };
        }
    }
}
