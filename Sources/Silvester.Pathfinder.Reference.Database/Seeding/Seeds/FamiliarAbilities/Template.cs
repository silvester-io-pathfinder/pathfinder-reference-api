using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities
{
    public abstract class Template : EntityTemplate<FamiliarAbility>
    {
        protected override FamiliarAbility GetEntity(ModelBuilder builder)
        {
            FamiliarAbility ability = GetFamiliarAbility();

            builder.AddSourcePage(ability, GetSourcePage(), (e) => e.SourcePageId);
            
            return ability;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract FamiliarAbility GetFamiliarAbility();
    }
}
