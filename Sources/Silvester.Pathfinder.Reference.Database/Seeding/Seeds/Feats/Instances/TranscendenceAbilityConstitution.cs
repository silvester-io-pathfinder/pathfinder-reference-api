using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranscendenceAbilityConstitution : Template
    {
        public static readonly Guid ID = Guid.Parse("27859058-acc5-4835-85c5-81c86752ab20");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Transcendence Ability - Constitution",
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
            yield return new TextBlock { Id = Guid.Parse("3a1e9b04-f4b8-4248-b5d0-5f34111fbcba"), Type = TextBlockType.Text, Text = "Your eidolon&#39;s Constitution ability score increases by 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("194f918e-e94d-43d5-a2b7-4902c3bd78f8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
