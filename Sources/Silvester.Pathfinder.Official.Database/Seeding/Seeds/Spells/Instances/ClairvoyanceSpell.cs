﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClairvoyanceSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("af9903ec-8e9e-4752-bae4-042aca73f91a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clairvoyance",
                Level = 4,
                Range = 500,
                CastTime = TimeSpan.FromMinutes(1),
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe688355-a855-421f-bb33-20b2fd2b25d1"), Type = Utilities.Text.TextBlockType.Text, Text = "You create an invisible floating eye at a location within range (even if it’s outside your line of sight or line of effect). The eye can’t move, but you can see in all directions from that point as if using your normal visual senses." };
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
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }
    }
}
