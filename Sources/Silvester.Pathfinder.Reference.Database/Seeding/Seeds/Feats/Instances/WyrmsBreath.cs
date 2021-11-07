using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WyrmsBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("a2ef8a5a-b3bd-4f8e-8b8b-bf7ddb0869a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wyrm's Breath",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8fd59c2d-c9fb-4702-9e96-e0aa24f1e73b"), Type = TextBlockType.Text, Text = "Your eidolon gathers the power of the mightiest wyrms to make its magical breath even more spectacular. If your eidolon’s next action is to use (action: Breath Weapon), both the number of damage dice and area of the (action: Breath Weapon) are doubled." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac89e600-2251-4746-8ced-73fce98c3485"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
