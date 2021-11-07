using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("ef1b095f-20e5-4a6b-b417-70dfe7309105");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Magic",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("398d6ea7-3a5e-48f2-ad90-c9971b2f2aeb"), Type = TextBlockType.Text, Text = "You gain the ability to fuse and play with shadows by using focus spells specific to shadowcaster. You learn a shadowcaster focus spell of your choice: (spell: dance of darkness) or (spell: shadow jump). If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by meditating within an area of dim light or darkness. The rules for focus spells appear on page 300." };
            yield return new TextBlock { Id = Guid.Parse("8317fbeb-7001-43ba-86c9-299014526d63"), Type = TextBlockType.Text, Text = "Shadowcaster focus spells are occult spells. You become trained in occult spell attack rolls and spell DCs, and your spellcasting ability for these spells is Charisma." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d7c03881-d8db-40f2-85ca-d9d714fda9bd"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("837651de-e9ef-4b34-be76-d8254bbe4aa0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
