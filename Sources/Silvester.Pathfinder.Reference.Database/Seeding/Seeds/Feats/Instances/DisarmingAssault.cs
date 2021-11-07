using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisarmingAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("0e72f4ae-9ed4-4bfc-bf87-5e1a454c35c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disarming Assault",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a271814d-f994-49b8-b4e8-99d2322b5874"), Type = TextBlockType.Text, Text = "You attack with enough force to knock the weapon out of your foe’s hands. Make a melee (action: Strike); if you hit, you can attempt an Athletics check to (action: Disarm) that foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d4ad5ee5-f456-488d-b063-451e93102897"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("557a4175-cecc-4ea7-aa2a-f86efd2097e1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
