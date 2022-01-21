using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrainAnimal : Template
    {
        public static readonly Guid ID = Guid.Parse("0500c24b-1bb9-4b19-9ce7-3f4c03683c57");

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
            yield return new TextBlock { Id = Guid.Parse("1773916c-d944-45ad-8410-e5f2ff1b797a"), Type = TextBlockType.Text, Text = "You spend time teaching an animal to do a certain action. You can either select a basic action the animal already knows how to do (typically those listed in the (action: Command an Animal) action) or attempt to teach the animal a new basic action. The GM determines the DC of any check required and the amount of time the training takes (usually at least a week). It's usually impossible to teach an animal a trick that uses critical thinking. If you're expert, master, or legendary in Nature, you might be able to train more unusual creatures, at the GM's discretion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ff1415a0-6f89-4e70-8f7b-eb33e6b421ed"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("92692a78-e998-4362-b70e-1aa50af1f4a0"),
                
                Success = "The animal learns the action. If it was an action the animal already knew, you can (action: Command the Animal | Command an Animal) to take that action without attempting a Nature check. If it was a new basic action, add that action to the actions the animal can take when (action: Commanded | Command an Animal), but you must still roll.",
                Failure = "The animal doesn't learn the trick.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0ce0c07-c73c-4ab9-8326-ef18ad6fcbbe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
