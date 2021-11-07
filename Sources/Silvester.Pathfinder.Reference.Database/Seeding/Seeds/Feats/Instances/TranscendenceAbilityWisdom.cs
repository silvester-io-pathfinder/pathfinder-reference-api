using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranscendenceAbilityWisdom : Template
    {
        public static readonly Guid ID = Guid.Parse("a70e3406-1cc5-4d99-a4be-644acb29165e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Transcendence Ability - Wisdom",
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
            yield return new TextBlock { Id = Guid.Parse("a897752c-6514-46ee-8ac0-ce797673c1c4"), Type = TextBlockType.Text, Text = "Your eidolon&#39;s Wisdom ability score increases by 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abfe3f5f-639a-4451-8a82-6ed0cce9c799"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
