using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UmbralExtraction : Template
    {
        public static readonly Guid ID = Guid.Parse("89c1fad3-8d00-4c2c-b057-a39ac825a7f7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Umbral Extraction",
                Level = 2,
                Duration = "3 rounds.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39c513c2-a092-4f55-9596-546580916d96"), Type = TextBlockType.Text, Text = "You prepare to steal spells from your foes, ripping them from the foe�s shadow to stow them in an ephemeral pocket in the Shadow Plane. You gain a temporary spell slot, which you can fill only by stealing a spell from an enemy spellcaster. During umbral extraction�s duration, you can use the Steal action to attempt to take one of the foe�s prepared spells or unused spontaneous spell slots instead of an item. You can also make one attempt to Steal as part of Casting umbral extraction. If you succeed at your check to Steal a spell, you deal 1d4 mental damage to the target per level of the spell stolen due to the psychological toll of the spiritual emptiness created by wrenching the spell away, and you place the stolen spell in your temporary spell slot. It gains the shadow trait if cast from this temporary slot." };
            yield return new TextBlock { Id = Guid.Parse("7b1a3ca2-4cf5-4605-8655-d69544848904"), Type = TextBlockType.Text, Text = "Determine the stolen spell at random from the target�s spells that are 1 level lower than umbral extraction, or from spells of the same level if you got a critical success. If the target has no spell slots of that level, use the highest level below that in which the target does have a spell slot. (If the target has no eligible spells, you get nothing, but you can continue to attempt to Steal spells for the remaining duration.) If the target is a prepared caster, you randomly steal one of their prepared spells. If the target is a spontaneous caster, you instead steal an unexpended spell slot of the appropriate level and determine the spell at random from all the target�s known spells at that level. You can�t steal a target�s innate spells, focus spells, or cantrips. You know what the spell is as soon as you steal it, and your temporary spell slot becomes a spell slot of the same level as the spell you stole." };
            yield return new TextBlock { Id = Guid.Parse("1e07d8c4-cdc4-4fdd-a48d-28d94d11ba9f"), Type = TextBlockType.Text, Text = "As normal, you can Steal only from a target within your reach. Once you�ve placed a spell in your temporary spell slot, you can�t attempt to Steal more spells. If you succeed at your Thievery check, you must take the spell you stole. Even if you�re a spontaneous caster, you can use the temporary spell slot only to cast the stolen spell and you can cast only the stolen spell from your temporary spell slot. When umbral extraction ends, you lose the temporary spell slot and any spell still stored in it. When you cast umbral extraction, any previous casting of umbral extraction currently affecting you ends." };
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
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Shadow.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64e7537d-8f34-4203-9258-21c744c755ac"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 137
            };
        }
    }
}
