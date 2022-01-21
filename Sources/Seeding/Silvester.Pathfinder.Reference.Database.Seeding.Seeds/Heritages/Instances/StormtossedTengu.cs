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
        public static readonly Guid ID = Guid.Parse("0f24eb20-b51d-4713-a39c-cf4d3b22ed7f");

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
            yield return new TextBlock { Id = Guid.Parse("801889cc-3493-4cd1-822a-bba2e01a7627"), Type = TextBlockType.Text, Text = "Whether due to a blessing from Hei Feng or hatching from your egg during a squall, you are resistant to storms. You gain electricity resistance equal to half your level (minimum 1). You automatically succeed at the flat check to target a concealed creature if that creature is concealed only by rain or fog." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("98194fe1-6cc8-4a19-a079-b0daf763d6cd"), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.Manual(Guid.Parse("faf81b09-33d7-4534-ae96-aa13953971cd"), "You automatically succeed at the flat check to target a concealed creature if that creature is concealed only by rain or fog.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("453f2f9e-b075-46f2-b14a-be6c71faa235"),
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
