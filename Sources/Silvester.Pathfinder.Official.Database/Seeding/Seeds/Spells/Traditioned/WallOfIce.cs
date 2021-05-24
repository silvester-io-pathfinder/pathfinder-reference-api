using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfIce : Template
    {
        public static readonly Guid ID = Guid.Parse("d6e7d875-4fe9-4647-a05b-bd7edfd02e01");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Ice",
                Level = 5,
                Range = "120 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed17ba9f-b289-488d-a411-00add20ccdb5"), Type = TextBlockType.Text, Text = "You sculpt an ice barrier that blocks sight and, once shattered, freezes foes. You create either a 1-foot-thick wall of ice in a straight line up to 60 feet long and 10 feet high (the wall doesn’t have to be vertical, but it must be anchored on both sides to a solid surface) or a 1-foot-thick, 10-foot radius hemisphere of ice. The ice that makes up the wall is opaque. If you wish, the wall can be of a smaller length, height, or radius. You must create the wall in an unbroken open space so its edges don’t pass through any creatures or objects, or the spell is lost." };
            yield return new TextBlock { Id = Guid.Parse("be994b46-706c-4c89-b69a-8619961877c4"), Type = TextBlockType.Text, Text = "Each 10-foot-by-10-foot section of the wall has AC 10, Hardness 10, and 40 Hit Points, and it’s immune to critical hits, cold damage, and precision damage. A section also has weakness to fire 15; a section of the wall destroyed by fire melts, evaporating into water and steam. A section destroyed by means other than fire leaves behind a chilling mass of ice that is difficult terrain and deals 2d6 cold damage to any creature passing through it." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bbd74a85-16b4-4c94-8455-9732bbba3220"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f72cc747-8979-4043-ba2c-6569062abe8e"), Type = TextBlockType.Text, Text = "The Hit Points of each section of the wall increase by 10, and the cold damage dealt to creatures crossing a destroyed section increases by 1d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d11d3a5a-78ad-4c03-a1ab-6c762167e7a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
