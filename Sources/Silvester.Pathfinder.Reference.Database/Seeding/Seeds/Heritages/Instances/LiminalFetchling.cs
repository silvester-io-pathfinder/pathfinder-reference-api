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
    public class LiminalFetchling : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Liminal Fetchling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You come from a line of fetchlings with a closer connection to the Ethereal Plane and Shadow Planes, and you share those realms' affinity with the in-between and unseen. You gain a +1 circumstance bonus to locate undetected creatures within 60 feet when using the Seek action. Your flat check to target concealed creatures is DC 3 instead of DC 5, and your flat check to target undetected creatures is DC 9 instead of DC 11." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificActionCircumstanceBonus(Guid.Parse(""), Actions.Instances.Seek.ID, bonus: 1);
            builder.Manual(Guid.Parse(""), "Your flat check to target concealed creatures is DC 3 instead of DC 5.");
            builder.Manual(Guid.Parse(""), "Your flat check to target undetected creatures is DC 9 instead of DC 11.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 85
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Fetchling.ID;
        }
    }
}
