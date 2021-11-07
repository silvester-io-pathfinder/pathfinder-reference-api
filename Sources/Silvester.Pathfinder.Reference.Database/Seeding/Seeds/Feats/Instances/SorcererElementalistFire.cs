using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistFire : Template
    {
        public static readonly Guid ID = Guid.Parse("833b00ac-33ee-42d6-b6a0-7f42bb40f277");

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
            yield return new TextBlock { Id = Guid.Parse("656cdf5b-a119-4827-9ba8-175754ba0f9e"), Type = TextBlockType.Text, Text = "You replace your initial bloodline spell with the initial fire elemental focus spell ((spell: wildfire)), and your advanced bloodline spell (if you get it) with the advanced fire elemental focus spell ((spell: combustion))." };
            yield return new TextBlock { Id = Guid.Parse("0d80f376-7e80-4cdc-88a6-f9cf0b6b917b"), Type = TextBlockType.Text, Text = "You can only select this option if your bloodline&#39;s elemental type is fire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d28aa20-42f2-478d-b783-a1ea774aed43"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
