using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GorillaPound : Template
    {
        public static readonly Guid ID = Guid.Parse("0ceca4e5-8ce1-41ba-8a93-c1bbd4fe2e7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gorilla Pound",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, while you are in Gorilla Stance, you gain a climb Speed of 15 feet.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89597a1d-3125-4516-89fd-f8559ce161d5"), Type = TextBlockType.Text, Text = $"You pound your chest before slamming into your foes. Attempt an Intimidation check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)}, then make one gorilla slam {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the same target. If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, you gain a circumstance bonus to the damage roll equal to triple the value of the target's frightened condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ce2869a8-d591-4846-a780-47d146ede46c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            builder.HaveSpecificFeat(Guid.Parse("d30bef44-5791-43fe-936b-7ce4020e81d0"), Feats.Instances.GorillaStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("beb19eaa-3f33-4429-80c7-df9bac21560c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
