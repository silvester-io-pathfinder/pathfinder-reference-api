using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrainAnimal : Template
    {
        public static readonly Guid ID = Guid.Parse("1a6a20fb-4a08-44b1-b5ae-7f1bbe1f09d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Train Animal",
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
            yield return new TextBlock { Id = Guid.Parse("6ea71b9b-7b9b-4f7e-a8de-3c03127321af"), Type = TextBlockType.Text, Text = "You spend time teaching an animal to do a certain action. You can either select a basic action the animal already knows how to do (typically those listed in the (action: Command an Animal) action) or attempt to teach the animal a new basic action. The GM determines the DC of any check required and the amount of time the training takes (usually at least a week). It’s usually impossible to teach an animal a trick that uses critical thinking. If you’re expert, master, or legendary in Nature, you might be able to train more unusual creatures, at the GM’s discretion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3b441c4e-0022-4866-bd4e-71c0cc602667"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f42644c9-b59e-4528-8ebc-dd72da706f54"),
                
                Success = "The animal learns the action. If it was an action the animal already knew, you can (action: Command the Animal | Command an Animal) to take that action without attempting a Nature check. If it was a new basic action, add that action to the actions the animal can take when (action: Commanded | Command an Animal), but you must still roll.",
                Failure = "The animal doesn’t learn the trick.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29e8f1b3-f464-4c9f-aee9-5d6db3107f23"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
