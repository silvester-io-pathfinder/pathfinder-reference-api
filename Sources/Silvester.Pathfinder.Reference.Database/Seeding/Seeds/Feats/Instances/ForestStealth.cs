using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForestStealth : Template
    {
        public static readonly Guid ID = Guid.Parse("77995842-1a96-4d1f-910f-4615fa94da16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forest Stealth",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3ae445b-f648-4fee-8d3d-f93f3359dfe8"), Type = TextBlockType.Text, Text = "You are skilled at quickly hiding behind bits of underbrush or foliage. You (Action: Take Cover) and then use that cover to (Action: Hide)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3563c663-cad3-4d8b-9a61-1fb75ef4b204"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c57e235-606c-475e-84dc-d406c3bdd1d9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
