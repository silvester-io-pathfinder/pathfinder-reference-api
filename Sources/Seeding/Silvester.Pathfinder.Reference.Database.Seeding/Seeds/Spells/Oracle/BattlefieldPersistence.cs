using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Divine.ID;
            yield return Traits.Instances.Oracle.ID;
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
