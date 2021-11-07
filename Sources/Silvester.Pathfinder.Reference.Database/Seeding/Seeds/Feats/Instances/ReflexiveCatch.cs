using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflexiveCatch : Template
    {
        public static readonly Guid ID = Guid.Parse("27e28e85-c8f6-456b-aee0-267c2ca93de6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflexive Catch",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An item falls within your reach or an attacker fails an attack roll to hit you or a creature within your reach with a thrown weapon.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ceb5c417-dcb7-4208-8e29-7b49fe9375fd"), Type = TextBlockType.Text, Text = "You grab the triggering item. If you are (feat: Juggling | Juggle), you can immediately add the item to the objects you’re (feat: Juggling | Juggle) as a free action, which has the (trait: concentrate) and (trait: manipulate) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3ed96e22-7dfb-4b0a-8427-6a8373d7f76e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificFeat(Guid.Parse("e56217c6-1869-4daf-af63-aff75e380a13"), Feats.Instances.JugglerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b30f493-4879-44b1-bff3-81e39f53b95c"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
