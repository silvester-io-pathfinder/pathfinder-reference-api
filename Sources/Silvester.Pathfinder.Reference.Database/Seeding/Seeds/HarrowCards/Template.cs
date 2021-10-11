using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowCards
{
    public abstract class Template : EntityTemplate<HarrowCard>
    {
        protected override HarrowCard GetEntity(ModelBuilder builder)
        {
            HarrowCard card = GetHarrowCard();
            return card;
        }

        protected abstract HarrowCard GetHarrowCard();
    }
}
