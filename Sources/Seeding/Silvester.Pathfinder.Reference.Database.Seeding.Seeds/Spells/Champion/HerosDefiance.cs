using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
            yield return new TextBlock { Id = Guid.Parse("2361ccc1-2b69-41a6-b7cc-5d0f6602e5ce"), Type = TextBlockType.Text, Text = "You shout in defiance, filling you with a sudden burst of healing. Just before applying the attack's damage, you recover 10d4+20 Hit Points. If this is enough to prevent the attack from bringing you to 0 Hit Points, you don't become unconscious or dying. Either way, cheating death is difficult, and you can't use hero's defiance again until you Refocus or the next time you prepare. Hero's defiance cannot be used against effects with the death trait or that would leave no remains, such as disintegrate." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("5ba63916-a8b2-442e-a50f-5f0926482c0e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0e17e6f9-2a3e-49f0-bc91-97cdb7349065"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("15e7206d-2f57-4485-88c8-86690202edbf"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("c4b6115e-0d8e-4a9f-80f9-a40e15b9a2e5"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("7baec17c-02ce-4374-9181-1e015fc1dbeb"), Traits.Instances.Positive.ID);
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
