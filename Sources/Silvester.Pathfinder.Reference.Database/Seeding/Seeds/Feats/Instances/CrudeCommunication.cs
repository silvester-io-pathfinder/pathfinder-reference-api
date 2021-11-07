using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrudeCommunication : Template
    {
        public static readonly Guid ID = Guid.Parse("801b79b8-3399-4184-8af8-2c6ed7ec66f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crude Communication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aac746e6-150f-4754-8b75-989395edbe17"), Type = TextBlockType.Text, Text = "Even if you don’t speak a creature’s language, you can rely on inflection, root words, and body language to infer rudimentary meaning. If you interact with a creature for at least 10 minutes and that creature can speak a language, the GM rolls a secret Society check with a DC appropriate for the language’s rarity. On a success, you understand the gist of the meaning and can communicate basic concepts back to the creature; on a failure, you are mistaken or communicate incorrect concepts. If you’re legendary in Society, you can communicate instantly without needing to attempt a Society check; even if you didn’t know the medium of communication the creature uses (speech, sign language, and so on), you intuit this information as soon as they try to communicate." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("706e8ac6-9517-4e6e-a5bf-3802fbda09ae"), Feats.Instances.LinguistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0a2a1df-72dd-4532-a07f-9264cdeb46fa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
