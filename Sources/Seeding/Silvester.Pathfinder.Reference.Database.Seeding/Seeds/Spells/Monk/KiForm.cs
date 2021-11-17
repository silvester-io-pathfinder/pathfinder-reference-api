using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class KiForm : Template
    {
        public static readonly Guid ID = Guid.Parse("914cab4d-07f4-422e-9c00-32be4e544665");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ki Form",
                Level = 9,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1372d74-d82f-4d76-a3e2-51ee6b554541"), Type = TextBlockType.Text, Text = "Drawing from deep wells of spiritual power, you take on a special ki form. In your ki form, your hair, feathers, skin, or scales change color and begin to glow. In this form you gain a fly Speed equal to your land Speed. Choose force, lawful (only if you are lawful), negative, or positive damage. All your Strikes deal 1d6 additional damage of the chosen type. Your entire body is also surrounded by a glowing corona of the same color as your inner ki; this is a light effect. Your corona is a 5-foot emanation that deals 2d6 damage of the chosen type to creatures who start their turn within the emanation. If the emanation overlaps with a darkness effect, the corona’s glow attempts to counteract the darkness effect. Regardless of the outcome, the corona can’t attempt to counteract that effect again for 1 day. As a single action, which has the concentrate trait, you can flare your corona out to become a 30-foot emanation." };
            yield return new TextBlock { Id = Guid.Parse("db5c707c-8105-4336-a503-33d265c574cb"), Type = TextBlockType.Text, Text = "In your ki form, your emotions surge to the forefront and it’s difficult to moderate your attacks. Your weapons and unarmed attacks lose the nonlethal trait. You take a –2 status penalty to saves against emotion effects but gain a +2 status bonus to saves against all other mental effects." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Polymorph.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("112a69cd-03e2-4d1a-b752-08f8d392b4e4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 229
            };
        }
    }
}
