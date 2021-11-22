using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneSensitivity : Template
    {
        public static readonly Guid ID = Guid.Parse("c9c2010b-6411-416d-8c77-28b931bd8b8b");

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
            yield return new TextBlock { Id = Guid.Parse("cd6b2317-bfe4-4313-bb64-3cc4c2bcc6de"), Type = TextBlockType.Text, Text = "You can sense the presence of the supernatural, even if you don't have any magical ability yourself. You can spend a single action (this action has the (trait: concentrate) trait) to determine if any magical auras are present in the area. This has the effects of a 1st-level (spell: detect magic) spell but isn't magical. By straining, you can also discover the source of the magic and its school (with the effect of a 4th-level (spell: detect magic) spell), but doing so prevents you from using this ability again until you've rested for 8 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("04e92a3c-c709-43f4-aec7-1fadb5f4042a"), Feats.Instances.EdgewatchDetectiveDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f809b246-f13a-461f-870a-b7e39f6cff44"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
