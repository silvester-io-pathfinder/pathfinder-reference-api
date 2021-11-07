using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistDontChange : Template
    {
        public static readonly Guid ID = Guid.Parse("8e05b780-251a-4d90-a6f1-adb60f0a7f8f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Don't Change",
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
            yield return new TextBlock { Id = Guid.Parse("8578c974-3bb5-4ebc-8367-9be3e0ee59ab"), Type = TextBlockType.Text, Text = "You choose not to replace your initial and advanced bloodline spells with elemental focus spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df0bf2fe-3a5d-42c2-81f3-a22bbe688a13"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
