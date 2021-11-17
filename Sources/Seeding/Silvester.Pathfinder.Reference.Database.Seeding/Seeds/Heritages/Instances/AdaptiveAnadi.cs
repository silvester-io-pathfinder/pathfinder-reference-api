using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class AdaptiveAnadi : Template
    {
        public static readonly Guid ID = Guid.Parse("e970c4dd-32db-4d43-af27-9d40e943b23f");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Adaptive Anadi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("547c1dc6-b34f-43e9-8d2b-739ee5846aa5"), Type = TextBlockType.Text, Text = "You descend from a line of anadi who worked to perfect their transformation magic, allowing them to integrate into a wider variety of cultures. Choose a common, Medium humanoid ancestry. Your human form is replaced with a form that matches this choice. You also gain the Adopted Ancestry feat for your chosen humanoid ancestry." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("de074020-84a5-46d6-ba57-aeadea298c00"), "Choose a common, Medium humanoid ancestry. Your human form is replaced with a form that matches this choice. ");	
            builder.GainSpecificFeat(Guid.Parse("d81dd7e5-99ad-4bdc-b436-40bc89a6f762"), Feats.Instances.AdoptedAncestry.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6c2df72-3dd7-4dd3-9247-8896c18f5a03"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 103
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Anadi.ID;
        }
    }
}
