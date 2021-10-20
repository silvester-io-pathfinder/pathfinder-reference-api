using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Doctrines
{
    public abstract class Template : EntityTemplate<Doctrine>
    {
        protected override Doctrine GetEntity(ModelBuilder builder)
        {
            Doctrine doctrine = GetDoctrine();

            builder.AddSourcePage(doctrine, GetSourcePage(), e => e.SourcePageId);
            builder.AddEffects(GetEffects(), (e) => new DoctrineEffectBinding { DoctrineId = doctrine.Id });

            return doctrine;
        }

        public abstract Doctrine GetDoctrine();
        public abstract SourcePage GetSourcePage();
        public abstract IEnumerable<Effect> GetEffects();
    }
}
