using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class LostOmensMwangiExpanse : Template
    {
        public static readonly Guid ID = Guid.Parse("8fa00726-c889-49ce-8566-28adec950f6c");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Lost Omens - Mwangi Expanse"
            };
        }
    }
}
