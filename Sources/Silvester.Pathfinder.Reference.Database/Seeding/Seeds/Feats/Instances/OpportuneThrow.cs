using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OpportuneThrow : Template
    {
        public static readonly Guid ID = Guid.Parse("172d45f9-1b15-4c63-b8ba-552f157debd1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Opportune Throw",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 10 feet of you uses a manipulate action or a move action, makes a ranged attack, or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a99637d-527f-4823-9748-d6493c2ec1b0"), Type = TextBlockType.Text, Text = "You make a thrown ranged (action: Strike) with the required weapon against the triggering creature. If you critically succeed and the trigger was a (trait: manipulate) action, you disrupt that action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3bddacf3-65ff-4e88-acdb-9146d1a347e7"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificFeat(Guid.Parse("a4e87f85-42a4-4ab0-acf7-2e0051d2df6e"), Feats.Instances.JugglerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac0e555a-aae6-4865-b4f7-7771c1a8cd8c"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
