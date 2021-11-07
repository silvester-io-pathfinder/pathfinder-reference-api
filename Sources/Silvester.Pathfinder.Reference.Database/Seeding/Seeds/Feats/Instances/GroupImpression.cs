using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GroupImpression : Template
    {
        public static readonly Guid ID = Guid.Parse("be9e1043-4764-486f-a547-bc6318016a63");

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
            yield return new TextBlock { Id = Guid.Parse("1d03e59e-2e61-4bbf-97cd-71eebbe5ea83"), Type = TextBlockType.Text, Text = "When you (action: Make an Impression), you can compare your Diplomacy check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f62c86d7-b056-4442-8728-f6934caef49e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8468abbf-467e-443a-af14-1d1e31e95fe5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
