using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialWord : Template
    {
        public static readonly Guid ID = Guid.Parse("fc4e1708-1f52-4186-b1cb-ca49027b2dd8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Word",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b321afb4-629f-4315-bf97-c71e753e8e59"), Type = TextBlockType.Text, Text = "You can call forth a holy word from the celestial realms to punish your foes. Once per day, you can cast (spell: divine decree) as a 7th-level divine innate spell. You must choose good for the spell&#39;s alignment, and you can (activity: Cast the Spell | Cast a Spell) regardless of whether you worship a deity or what their alignment is." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8745ac14-4552-483e-a1e7-09ae32dbc434"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
