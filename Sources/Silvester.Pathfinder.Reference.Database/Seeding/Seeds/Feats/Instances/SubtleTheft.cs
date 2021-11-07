using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SubtleTheft : Template
    {
        public static readonly Guid ID = Guid.Parse("7cc61d20-a612-4f64-9e93-8c73f98ac69e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subtle Theft",
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
            yield return new TextBlock { Id = Guid.Parse("847ded19-6d84-40f9-8873-6cdb703db867"), Type = TextBlockType.Text, Text = "When you successfully (Action: Steal) something, observers (creatures other than the creature you stole from) take a -2 circumstance penalty to their Perception DCs to detect your theft. Additionally, if you first (Action: Create a Diversion) using Deception, taking a single (Action: Palm an Object) or (Action: Steal) action doesn’t end your undetected condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("aa5c9089-207f-4acf-b4c0-6f776e94cb1c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce061179-b337-43d7-8324-c7ff680f95bb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
