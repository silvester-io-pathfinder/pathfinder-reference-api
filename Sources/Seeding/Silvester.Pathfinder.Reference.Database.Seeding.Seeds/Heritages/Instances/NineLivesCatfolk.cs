using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class NineLivesCatfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("d18e3ac8-c205-494a-bfdf-e64765eae89d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Nine Lives Catfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("72f880af-3b1c-45f0-9d96-01d8f06dbe3f"), Type = TextBlockType.Text, Text = "Your family has always seemed to bounce back from disaster, not through physical hardiness or specialized skill, but from sheer luck. Other catfolk whisper that you have nine lives. If you are reduced to 0 Hit Points by a critical hit on an attack roll, you become dying 1 instead of dying 2." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("dc212850-a935-42fd-a516-89ce59a9b317"), "If you are reduced to 0 Hit Points by a critical hit on an attack roll, you become dying 1 instead of dying 2.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad6650c0-77d6-4043-8f91-bde9042de7a0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 10
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
        }
    }
}
