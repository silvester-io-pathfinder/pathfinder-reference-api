using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranscendenceAbilityDexterity : Template
    {
        public static readonly Guid ID = Guid.Parse("1e93f2cd-7391-414e-8f58-6c383ab59502");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Transcendence Ability - Dexterity",
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
            yield return new TextBlock { Id = Guid.Parse("a88d72bf-1150-4c7f-8a43-f09ed0d340c7"), Type = TextBlockType.Text, Text = "Your eidolon&#39;s Dexterity ability score increases by 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3970bd5b-a8e5-4a35-9d66-76d6c811aa36"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
