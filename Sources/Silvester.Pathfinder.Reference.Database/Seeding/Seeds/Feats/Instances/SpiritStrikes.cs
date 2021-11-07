using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("8d5cdfaf-f66d-4bac-a5cc-040b1f57717f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirit Strikes",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad18d67c-91ae-4629-9b7b-0a77c18eb5d8"), Type = TextBlockType.Text, Text = "Your connection to the Boneyard empowers you to bring death to all forms of life and unlife, exploiting their weaknesses. All your weapon and unarmed (action: Strikes | Strike) are magical and deal 1 additional negative damage to living creatures and 1 additional positive damage to undead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6ca90f3-72cf-4ef3-af82-783fbd9de346"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
