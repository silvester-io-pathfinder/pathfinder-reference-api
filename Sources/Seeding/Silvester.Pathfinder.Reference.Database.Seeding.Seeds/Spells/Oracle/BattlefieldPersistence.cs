using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BattlefieldPersistence : Template
    {
        public static readonly Guid ID = Guid.Parse("ce8baedc-c775-4830-82b0-f22d82de0666");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Battlefield Persistence",
                Level = 3,
                Trigger = "You are about to attempt a saving throw, but you haven't rolled yet.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e235e8e0-1909-4c19-83bb-42345cc9b8a6"), Type = TextBlockType.Text, Text = "You're difficult to remove from battle. You gain a +2 status bonus to the triggering save, and if the triggering save is against an incapacitation effect, it treats you as if you were 2 levels higher." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c4278cfc-0b21-487c-8bf4-2b6fc1e7694c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7dcc1e3e-e961-46a0-a1d0-d65f39bfed55"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("28d4ff2e-567f-4a77-87a2-c0820a563ed8"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("4575a725-e6db-4c85-9a4d-8811746f76ed"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("da378d66-499c-4c27-82b3-1c551a598c00"), Traits.Instances.Oracle.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf9b20dd-a0de-4181-abb6-7a749467d121"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
