using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistFire : Template
    {
        public static readonly Guid ID = Guid.Parse("c3d9ffce-8534-4f32-890e-ea30f81278d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Fire",
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
            yield return new TextBlock { Id = Guid.Parse("3a318a71-2a54-416c-8626-940be6ca1e06"), Type = TextBlockType.Text, Text = "You replace your initial bloodline spell with the initial fire elemental focus spell ((spell: wildfire)), and your advanced bloodline spell (if you get it) with the advanced fire elemental focus spell ((spell: combustion))." };
            yield return new TextBlock { Id = Guid.Parse("3f13bbc5-f9ad-4b8f-bc87-58a4e638d082"), Type = TextBlockType.Text, Text = "You can only select this option if your bloodline&#39;s elemental type is fire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6526ec4-aca8-4072-a8f7-2ffdaa7fbcb6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
