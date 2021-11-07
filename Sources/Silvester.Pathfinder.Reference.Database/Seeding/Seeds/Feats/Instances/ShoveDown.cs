using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShoveDown : Template
    {
        public static readonly Guid ID = Guid.Parse("fd44146e-a5c1-4940-ac20-25192631581b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shove Down",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d4a121e-92b6-4c87-8cc7-81c3adca9323"), Type = TextBlockType.Text, Text = "You leverage your weight to topple foes that you move. You attempt to (action: Trip) the target, even if the target is no longer in your reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("29ee03b9-ed1d-40ce-ae7e-7b51cded7b98"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70c494a6-c47f-49b5-a3a0-fc2b9086268c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
