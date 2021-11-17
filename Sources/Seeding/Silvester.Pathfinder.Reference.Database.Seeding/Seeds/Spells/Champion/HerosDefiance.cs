using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HerosDefiance : Template
    {
        public static readonly Guid ID = Guid.Parse("3559859d-517e-45ae-a5b8-34e5b7c49e48");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hero's Defiance",
                Level = 10,
                Trigger = "An attack would bring you to 0 Hit Points.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2361ccc1-2b69-41a6-b7cc-5d0f6602e5ce"), Type = TextBlockType.Text, Text = "You shout in defiance, filling you with a sudden burst of healing. Just before applying the attack’s damage, you recover 10d4+20 Hit Points. If this is enough to prevent the attack from bringing you to 0 Hit Points, you don’t become unconscious or dying. Either way, cheating death is difficult, and you can’t use hero’s defiance again until you Refocus or the next time you prepare. Hero’s defiance cannot be used against effects with the death trait or that would leave no remains, such as disintegrate." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Champion.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a889ffd-d46d-472e-a843-52273c68208d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
