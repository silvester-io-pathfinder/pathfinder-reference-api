using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialResistanceElectricity : Template
    {
        public static readonly Guid ID = Guid.Parse("b7cdba8c-c5c1-4467-bdb1-eb0d05f3e19a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Resistance - Electricity",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b737f09-e321-4246-a0b4-ad1aa873cff1"), Type = TextBlockType.Text, Text = "You gain resistance 5 to electricity." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cfe3d27-98b9-4b3c-8401-2c6e6ee7b7d8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
