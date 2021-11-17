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
    public class RiverAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("7c3a2c0f-fac3-47f3-bcc8-dfc91c707bfd");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "River Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1c60799d-4a7a-43fc-b1f1-a71b68167ca6"), Type = TextBlockType.Text, Text = "You come from azarketis who abandoned the oceans for the fresh water of inland life. The varied geography of rivers required you to develop advanced physical skills to swim against rapids, leap through cascading waters, and deftly navigate shallow and narrow channels. When you succeed at an Athletics check to Swim, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificSkillActionCheck(Guid.Parse("e47221fc-a9ea-4584-92fa-95522d455f66"), SkillActions.Instances.Swim.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6b29ee8-7554-4011-908d-cc614b9b9900"),
                SourceId = Sources.Instances.AzarketiAncestryWebSupplement.ID,
                Page = 3
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
