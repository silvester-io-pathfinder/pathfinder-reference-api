using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Firearm : Template
    {
        public static readonly Guid ID = Guid.Parse("17f8ade5-4273-4d72-9f71-36fac6aadbd5");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Firearm",
                CriticalEffect = "The target must succeed at a Fortitude save against your class DC or be stunned 1."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3f3880e-d6b7-4763-9c54-e7fb0652b826"),
                SourceId = GunsAndGears.ID,
                Page = 152
            };
        }
    }
}
