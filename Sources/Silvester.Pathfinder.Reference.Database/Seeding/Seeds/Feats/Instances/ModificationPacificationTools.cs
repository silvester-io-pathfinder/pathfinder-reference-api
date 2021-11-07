using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationPacificationTools : Template
    {
        public static readonly Guid ID = Guid.Parse("aaee3be1-9e51-48f7-9198-3a404f24de12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Pacification Tools",
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
            yield return new TextBlock { Id = Guid.Parse("c1baa265-f1aa-477c-b2b6-839c068a1029"), Type = TextBlockType.Enumeration, Text = "*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("3bdb7274-bc20-4a50-839c-8a3dadc35aac"), Type = TextBlockType.Text, Text = "Softer materials make your weapon suited to knock out instead of kill, and special protrusions let you catch weapons and disarm your foes. Your innovation gains the (trait: disarm) and (trait: nonlethal) traits. You can choose whether to apply the (trait: nonlethal) trait on each attack with your innovation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("350190c0-c89a-44a9-9197-ce51367c8d95"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
