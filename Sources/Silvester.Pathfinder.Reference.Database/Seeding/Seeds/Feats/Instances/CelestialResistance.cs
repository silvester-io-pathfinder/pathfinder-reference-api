using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("cb7132d1-e217-4cc8-9508-f3ce1884a6dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Resistance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bfb1d7cc-3c5c-4284-bd7c-22ce15219c66"), Type = TextBlockType.Text, Text = "Your growing connection to your celestial forebears has granted you one of their resistances as well. Choose one of the following energy damage types: acid, cold, electricity, fire, or sonic. You gain resistance 5 to that damage type." };
            yield return new TextBlock { Id = Guid.Parse("ab658355-0bb0-4b70-877f-fc817b9702ef"), Type = TextBlockType.Text, Text = "Though you can choose any of these energy damage types, the damage type typically matches a celestial associated with your bloodline. For instance, an angelkin might choose resistance to cold or fire with a cassisian forebear, resistance to fire with a balisse forebear, or resistance to sonic with a choral forebear." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52c3f3ec-8710-48be-97e9-4596aea2fb52"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
