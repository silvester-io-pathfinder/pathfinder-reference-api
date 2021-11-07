using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistAir : Template
    {
        public static readonly Guid ID = Guid.Parse("af7ec633-83f2-4e0d-8c69-87a150fff99e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Air",
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
            yield return new TextBlock { Id = Guid.Parse("d25eb379-58b9-4570-8551-e94408d324f4"), Type = TextBlockType.Text, Text = "You replace your initial bloodline spell with the initial air elemental focus spell ((spell: updraft)), and your advanced bloodline spell (if you get it) with the advanced air elemental focus spell ((spell: powerful inhalation))." };
            yield return new TextBlock { Id = Guid.Parse("f6f38dd4-203f-44eb-a010-48869cc9ad13"), Type = TextBlockType.Text, Text = "You can only select this option if your bloodline&#39;s elemental type is air." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ef76879-7b65-4ea7-bd36-1e1b73af146f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
