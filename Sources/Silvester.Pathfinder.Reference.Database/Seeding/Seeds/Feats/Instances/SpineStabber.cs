using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpineStabber : Template
    {
        public static readonly Guid ID = Guid.Parse("25284c40-b76e-4b23-93a7-358a1f4c7c68");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spine Stabber",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f73c1eec-88d9-4591-ae45-aa2cdec8689d"), Type = TextBlockType.Text, Text = "The quills on your arms are particularly sharp and sturdy. You gain a quills unarmed attack that deals 1d6 piercing damage. Your quills are in the knife weapon group and have the (trait: finesse) and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("143682e8-1f38-4d96-8270-4f39e30010d8"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
