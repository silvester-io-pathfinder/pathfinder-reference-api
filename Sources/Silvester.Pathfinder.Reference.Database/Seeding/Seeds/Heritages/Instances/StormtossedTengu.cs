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
    public class StormtossedTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Stormtossed Tengu"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Whether due to a blessing from Hei Feng or hatching from your egg during a squall, you are resistant to storms. You gain electricity resistance equal to half your level (minimum 1). You automatically succeed at the flat check to target a concealed creature if that creature is concealed only by rain or fog." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.Manual(Guid.Parse(""), "You automatically succeed at the flat check to target a concealed creature if that creature is concealed only by rain or fog.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 26
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Tengu.ID;
        }
    }
}
