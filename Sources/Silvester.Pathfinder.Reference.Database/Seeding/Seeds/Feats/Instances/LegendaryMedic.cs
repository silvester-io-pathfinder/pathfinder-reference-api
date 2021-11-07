using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryMedic : Template
    {
        public static readonly Guid ID = Guid.Parse("5196bb0f-ec75-44de-b739-48dfa50a41c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Medic",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a6dcc018-ce10-4648-8682-5b761c0ba1f3"), Type = TextBlockType.Text, Text = "You’ve discovered medical breakthroughs or techniques that achieve miraculous results. Once per day for each target, you can spend 1 hour treating that target and attempt a Medicine check to remove a disease or the blinded, deafened, doomed, or drained condition. Use the DC of the disease or of the spell or effect that created the condition. If the effect’s source is an artifact, above 20th level, or similarly powerful, increase the DC by 10." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("01ad0ddb-1515-4627-8960-ced7449720e1"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1084645-3fd8-44a0-82e5-cb2d661ccea6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
