using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TelluricPower : Template
    {
        public static readonly Guid ID = Guid.Parse("a6f8090b-5b0f-435a-a69a-b3ce0b1d597b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Telluric Power",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f7ad83b-8dbf-45de-8842-67cbf5d6e51e"), Type = TextBlockType.Text, Text = $"You channel strength from the earth beneath your feet to pummel your enemies. When making a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a target who is standing on the same earth or stone surface as you are, you gain a circumstance bonus to the damage roll equal to the number of weapon damage dice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bf65157-4cca-4558-ae4e-6b8bbe415aa6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
