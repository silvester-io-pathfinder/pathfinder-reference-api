using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class SecretsOfMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("021f2531-d790-4f48-8668-702c0467b7d0");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Secrets of Magic"
            };
        }
    }
}
