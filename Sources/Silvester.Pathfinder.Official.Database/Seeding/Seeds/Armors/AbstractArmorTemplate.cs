using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors
{
    public abstract class AbstractArmorTemplate : EntityTemplate<Armor>
    {
        protected override Armor GetEntity(ModelBuilder builder)
        {
            Armor armor = GetArmor();

            SourcePage sourcePage = GetSourcePage();
            armor.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            builder.AddTextBlocks(armor, GetDetails(), e => e.Details);

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<Armor, Trait>((armor.Id, traitId));
            }

            return armor;
        }

        protected abstract Armor GetArmor();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Guid> GetTraits();
    }
}
