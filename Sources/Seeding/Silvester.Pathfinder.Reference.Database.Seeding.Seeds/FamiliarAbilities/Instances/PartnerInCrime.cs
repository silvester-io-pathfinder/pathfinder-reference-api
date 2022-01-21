using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class PartnerInCrime : Template
    {
        public static readonly Guid ID = Guid.Parse("643818da-fe58-4305-bc34-0fefebaec929");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Partner in Crime", 
                Description = "Your familiar is your criminal associate. Despite being a minion, your familiar gains 1 reaction at the start of its turns, which it can use only to Aid you on a Deception or Thievery skill check (it still has to prepare to help you as normal for the Aid reaction). It automatically succeeds at its check to Aid you with those skills or automatically critically succeeds if you're a master of the skill in question."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58653145-d59b-4463-acdf-bd096022974b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}