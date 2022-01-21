using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DisperseIntoAir : Template
    {
        public static readonly Guid ID = Guid.Parse("461798c1-5e2c-4cfd-83bd-397308a6539b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Disperse Into Air",
                Level = 4,
                Trigger = "You take damage from an enemy or a hazard.",
                DomainId = Domains.Instances.Air.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09073233-3689-4b8b-87c4-2b1bb66319d6"), Type = TextBlockType.Text, Text = "After taking the triggering damage, you transform into air. Until the end of the current turn, you can't be attacked or targeted, you don't take up space, you can't act, and any auras or emanations you have are suppressed. At the end of the turn, you re-form in any space you can occupy within 15 feet of where you were when you dispersed. Any auras or emanations you had are restored as long as their duration didn't run out while you were dispersed." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8cfed1ee-47d7-4cd2-bc7d-ff0760cc7084"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d252ff12-04df-476e-b466-6fd89afd062f"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("7cea3c45-493c-4c18-9968-8d266fa4909b"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("719199a1-086d-4aa2-89f1-b799581b3d4f"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("838fa27f-2c69-45db-8a44-ec75695cf2dc"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d53f61c3-b3d6-4a38-915d-baa999c1bea6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 391
            };
        }
    }
}
