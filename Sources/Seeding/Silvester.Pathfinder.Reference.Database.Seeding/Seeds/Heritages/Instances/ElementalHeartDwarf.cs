using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ElementalHeartDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("801fba4a-dd78-4f76-beca-ff51faac7b7a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Elemental Heart Dwarf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8719530e-f8f8-4718-b721-c369e02f1500"), Type = TextBlockType.Text, Text = "Whether through a connection to Torag’s forge, the azers of the Plane of Fire, or another source, you can exude a burst of energy. Mbe’ke and Taralu dwarves of the Mwangi Expanse believe this heritage is a gift from dragons or elemental spirits. Choose one of the following damage types: acid, cold, electricity, or fire. Once chosen, this can’t be changed. You gain the Energy Emanation activity." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("49df0bc8-23fc-41ed-8710-4f0d789d302e"), Feats.Instances.EnergyEmanation.ID);
            //TODO: Add choice?
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12662105-08e5-4c72-90ec-2ef5e4ccec6d"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 19
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Dwarf.ID;
        }
    }
}