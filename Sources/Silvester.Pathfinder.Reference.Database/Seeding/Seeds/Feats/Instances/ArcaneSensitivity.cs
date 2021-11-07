using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneSensitivity : Template
    {
        public static readonly Guid ID = Guid.Parse("9465a7a6-dec4-4077-96c4-54c8b684874a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Sensitivity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d155179a-0089-47da-be21-891e4066d4b8"), Type = TextBlockType.Text, Text = "You can sense the presence of the supernatural, even if you don&#39;t have any magical ability yourself. You can spend a single action (this action has the (trait: concentrate) trait) to determine if any magical auras are present in the area. This has the effects of a 1st-level (spell: detect magic) spell but isn&#39;t magical. By straining, you can also discover the source of the magic and its school (with the effect of a 4th-level (spell: detect magic) spell), but doing so prevents you from using this ability again until you&#39;ve rested for 8 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("851fe55d-8aff-4caa-9f31-361509e3fe11"), Feats.Instances.EdgewatchDetectiveDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb289ac4-fc7e-4efb-a90f-57a4efc93396"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
