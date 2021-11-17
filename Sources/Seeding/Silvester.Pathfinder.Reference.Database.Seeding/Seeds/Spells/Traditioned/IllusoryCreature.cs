using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class IllusoryCreature : Template
    {
        public static readonly Guid ID = Guid.Parse("ddf1c0a5-80cd-418e-bf75-6012de4cf508");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Illusory Creature",
                Level = 2,
                Range = "500 feet.",
                IsDismissable = true,
                Duration = "Sustained",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4572b136-f51c-4384-b39d-564d1cac5519"), Type = TextBlockType.Text, Text = "You create an illusory image of a Large or smaller creature. It generates the appropriate sounds, smells, and feels believable to the touch. If you and the image are ever farther than 500 feet apart, the spell ends." };
            yield return new TextBlock { Id = Guid.Parse("400445db-e4f5-4963-9784-aaa2fd8460c0"), Type = TextBlockType.Text, Text = "The image can’t speak, but you can use your actions to speak through the creature, with the spell disguising your voice as appropriate. You might need to attempt a Deception or Performance check to mimic the creature, as determined by the GM. This is especially likely if you’re trying to imitate a specific person and engage with someone that person knows." };
            yield return new TextBlock { Id = Guid.Parse("d37629b1-c0ab-46df-9e31-bd4a5f65d2d9"), Type = TextBlockType.Text, Text = "In combat, the illusion can use 2 actions per turn, which it uses when you Sustain the Spell. It uses your spell attack roll for attack rolls and your spell DC for its AC. Its saving throw modifiers are equal to your spell DC – 10. It is substantial enough that it can flank other creatures. If the image is hit by an attack or fails a save, the spell ends." };
            yield return new TextBlock { Id = Guid.Parse("48685123-c565-4abf-beb9-da1b0656da26"), Type = TextBlockType.Text, Text = "The illusion can cause damage by making the target believe the illusion’s attacks are real, but it cannot otherwise directly affect the physical world. If the illusory creature hits with a Strike, the target takes mental damage equal to 1d4 plus your spellcasting ability modifier. This is a mental effect. The illusion’s Strikes are nonlethal. If the damage doesn’t correspond to the image of the monster—for example, if an illusory Large dragon deals only 5 damage—the GM might allow the target to attempt an immediate Perception check to disbelieve the spell. Any relevant resistances and weaknesses apply if the target thinks they do, as judged by the GM. For example, if the illusion wields a warhammer and attacks a creature resistant to bludgeoning damage, the creature would take less mental damage. However, illusory damage does not deactivate regeneration or trigger other effects that require a certain damage type. The GM should track illusory damage dealt by the illusion." };
            yield return new TextBlock { Id = Guid.Parse("29be0ae7-81fd-4621-a19b-d6df6a336edb"), Type = TextBlockType.Text, Text = "Any creature that touches the image or uses the Seek action to examine it can attempt to disbelieve your illusion. When a creature disbelieves the illusion, it recovers from half the damage it had taken from it (if any) and doesn’t take any further damage from it." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0b5f879c-6657-43d5-a86b-dcbe74eb1b6e"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2dcf6ec2-cb8d-4ab4-bf4f-ddf4edf63362"), Type = TextBlockType.Text, Text = "The damage of the image’s Strikes increases by 1d4, and the maximum size of creature you can create increases by one (to a maximum of Gargantuan)." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Olfactory.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ca35272-e50b-4f4f-ac95-2b62bae32646"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 345
            };
        }
    }
}
