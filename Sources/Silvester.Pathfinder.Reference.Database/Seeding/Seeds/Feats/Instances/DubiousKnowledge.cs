using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DubiousKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("47597a52-3b79-434f-b0df-8baa5e8ea4bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dubious Knowledge",
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
            yield return new TextBlock { Id = Guid.Parse("c98a900d-40d3-4726-85ef-1e23e8316c3f"), Type = TextBlockType.Text, Text = "You’re a treasure trove of information, but not all of it comes from reputable sources. When you fail (but not critically fail) a (action: Recall Knowledge) check using any skill, you learn a bit of true knowledge and a bit of erroneous knowledge, but you don’t have any way to differentiate which is which." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("fcb9ac7c-e985-4a87-b9db-430a517fc5ba"), Proficiencies.Instances.Trained.ID, requiresAssurance: False);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5a509ff-3ae4-4fe4-8aa1-635b239baaaa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
