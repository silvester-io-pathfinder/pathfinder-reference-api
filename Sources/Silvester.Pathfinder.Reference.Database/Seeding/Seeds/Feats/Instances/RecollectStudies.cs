using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecollectStudies : Template
    {
        public static readonly Guid ID = Guid.Parse("4cf34637-9010-4554-bf95-890750d44496");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recollect Studies",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4090f17e-ba13-4a96-8a89-f488bb583656"), Type = TextBlockType.Text, Text = "You paid attention during your studies and remember the right way to attack various creatures. Choose a creature that meets the requirements. You learn the resistances, immunities, or weaknesses of the creature (your choice) without needing to successfully (action: Recall Knowledge)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("093d2f02-68ba-46fc-b68d-a4225616af8d"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("b9fd6d3f-590b-493f-a657-e8f0527d6b8a"), Proficiencies.Instances.Expert.ID, requiresAssurance: False);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f99df56-38b4-4ecc-ae10-43597af15913"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
