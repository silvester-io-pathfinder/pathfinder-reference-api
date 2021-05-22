using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes
{
    public abstract class Template : EntityTemplate<ArmorPropertyRune>
    {
        protected override ArmorPropertyRune GetEntity(ModelBuilder builder)
        {
            ArmorPropertyRune rune = GetRune();

            builder.AddSourcePage(rune, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(rune, GetTraits());
            builder.AddTextBlocks(rune, GetDetails(), e => e.Details);

            ArmorPropertyRuneAction? action = GetAction();
            if(action != null)
            {
                action.RuneId = rune.Id;
                rune.ActionId = action.Id;
                builder.AddData(action);
            }

            return rune;
        }

        protected abstract ArmorPropertyRune GetRune();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies();
        
        protected virtual ArmorPropertyRuneAction? GetAction()
        {
            return null;
        }
    }
}
