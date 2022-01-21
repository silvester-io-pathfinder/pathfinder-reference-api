using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GroupImpression : Template
    {
        public static readonly Guid ID = Guid.Parse("194e86c8-177c-4195-9038-4516a9831440");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Group Impression",
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
            yield return new TextBlock { Id = Guid.Parse("395cca72-530f-490e-95de-51892357049b"), Type = TextBlockType.Text, Text = "When you (action: Make an Impression), you can compare your Diplomacy check result to the Will DCs of two targets instead of one. It's possible to get a different degree of success for each target. The number of targets increases to four if you're an expert, 10 if you're a master, and 25 if you're legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e4521936-3900-4231-94a3-9a524b8c2aee"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d652a5d-3e1e-4bf6-9c60-b3eb5de0f9b1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
