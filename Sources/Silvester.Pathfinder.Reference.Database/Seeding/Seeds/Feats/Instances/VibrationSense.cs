using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VibrationSense : Template
    {
        public static readonly Guid ID = Guid.Parse("c552218b-5cbb-4e5a-a218-2fa743c81643");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vibration Sense",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42262fea-e654-489a-8177-4b3e0b5ffe76"), Type = TextBlockType.Text, Text = "Your eidolon gains tremorsense as an imprecise sense with a range of 30 feet. If aquatic, it gains wavesense as an imprecise sense with a range of 30 feet instead. If amphibious, it gains both." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acf0be78-a253-4044-be99-b6c445bbd39b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
