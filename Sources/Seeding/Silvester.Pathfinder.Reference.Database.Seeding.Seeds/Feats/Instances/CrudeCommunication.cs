using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrudeCommunication : Template
    {
        public static readonly Guid ID = Guid.Parse("e2630b05-e8ec-44fe-be72-824dbb8952a3");

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
            yield return new TextBlock { Id = Guid.Parse("7b2ddda9-b3cd-49e1-bb6a-bef1eb2cc10c"), Type = TextBlockType.Text, Text = $"Even if you don't speak a creature's language, you can rely on inflection, root words, and body language to infer rudimentary meaning. If you interact with a creature for at least 10 minutes and that creature can speak a language, the GM rolls a secret Society check with a DC appropriate for the language's rarity. On a success, you understand the gist of the meaning and can communicate basic concepts back to the creature; on a failure, you are mistaken or communicate incorrect concepts. If you're legendary in Society, you can communicate instantly without needing to attempt a Society check; even if you didn't know the medium of communication the creature uses (speech, sign language, and so on), you intuit this information as soon as they try to communicate." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4b924d82-7219-40c0-a391-b1b17152c381"), Feats.Instances.LinguistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3758ae60-49fc-4597-b7b2-c23de3a97fdf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
