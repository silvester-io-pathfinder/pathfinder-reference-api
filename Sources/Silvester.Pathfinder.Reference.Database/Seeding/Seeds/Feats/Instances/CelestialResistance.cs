using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("5a5bc1a7-3f65-4a0a-8e43-3e209e919efd");

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
            yield return new TextBlock { Id = Guid.Parse("7a6334e3-06d7-4f9c-9f4c-53978d374d8a"), Type = TextBlockType.Text, Text = "Your growing connection to your celestial forebears has granted you one of their resistances as well. Choose one of the following energy damage types: acid, cold, electricity, fire, or sonic. You gain resistance 5 to that damage type." };
            yield return new TextBlock { Id = Guid.Parse("40ef2ce7-9c5c-4d47-aff4-d8469b06b21f"), Type = TextBlockType.Text, Text = "Though you can choose any of these energy damage types, the damage type typically matches a celestial associated with your bloodline. For instance, an angelkin might choose resistance to cold or fire with a cassisian forebear, resistance to fire with a balisse forebear, or resistance to sonic with a choral forebear." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90efc034-6fa1-4811-a909-ada353d31042"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
