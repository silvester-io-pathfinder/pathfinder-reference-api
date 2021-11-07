using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SettleEmotions : Template
    {
        public static readonly Guid ID = Guid.Parse("6834918b-5f1b-440b-b34d-88ef388b567b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Settle Emotions",
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
            yield return new TextBlock { Id = Guid.Parse("d66ee486-74de-4475-a071-7ea71e8dc167"), Type = TextBlockType.Text, Text = "You spend 10 minutes using techniques you’ve developed to calm your emotions and bring them back under control. This allows you to access your (feat: Catharsis) again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1d7ff20-8ad1-4aff-8edb-22c62d237d39"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
