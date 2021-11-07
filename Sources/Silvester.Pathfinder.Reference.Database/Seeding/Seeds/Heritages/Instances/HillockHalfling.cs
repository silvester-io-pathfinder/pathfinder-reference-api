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
    public class HillockHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("2edffa58-9514-4e51-82f8-e1b08e427aeb");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Hillock Halfling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Accustomed to a calm life in the hills, your people find rest and relaxation especially replenishing, particularly when indulging in creature comforts. When you regain Hit Points overnight, add your level to the Hit Points regained. When anyone uses the Medicine skill to Treat your Wounds, you can eat a snack to add your level to the Hit Points you regain from their treatment." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "When you regain Hit Points overnight, add your level to the Hit Points regained.");
            builder.Manual(Guid.Parse(""), "When anyone uses the Medicine skill to Treat your Wounds, you can eat a snack to add your level to the Hit Points you regain from their treatment.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 51
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Halfling.ID;
        }
    }
}
