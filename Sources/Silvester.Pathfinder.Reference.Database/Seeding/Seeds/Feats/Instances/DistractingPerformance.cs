using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("6f033bd2-20c2-4219-8ec8-a1d924cb5f20");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Performance",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd46196f-2d5b-48bd-a2e3-d090c129375e"), Type = TextBlockType.Text, Text = "Your performances are especially distracting, allowing your allies to (action: Sneak) away with ease. When you (action: Aid) an ally who is trying to (action: Create a Diversion), instead of the usual effects of (action: Aid), you can roll a Performance check and use that result to determine the outcome of the diversion, instead of the ally rolling a Deception check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("56d410f3-be18-4313-a74a-30fcc82bb903"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("951d08e5-c3e9-4d41-8949-b8447365365c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
