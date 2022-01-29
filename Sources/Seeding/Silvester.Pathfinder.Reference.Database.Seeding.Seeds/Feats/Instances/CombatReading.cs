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
    public class CombatReading : Template
    {
        public static readonly Guid ID = Guid.Parse("893b55ff-c927-4853-9d6a-4518aea625a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combat Reading",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47b8afc6-864b-4874-bda6-675cbd366351"), Type = TextBlockType.Text, Text = $"You use a performer's cold reading techniques, aura reading, and other tricks to discover your foe's strengths and weaknesses. The GM rolls a secret Occultism check for you against the Deception or Stealth DC (whichever is higher) of an enemy of your choice who is engaged in combat and isn't concealed from you, hidden from you, or undetected by you. The GM might apply a penalty for the distance between you and the enemy. The enemy is then temporarily immune to your Combat Reading for 1 day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bf089f6f-999c-40d4-9fd9-57d36e3f7e6b"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("be70bbf8-0d61-4a00-858a-5ab1ea99e96d"), Traits.Instances.Secret.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("dbf007fc-8178-441f-b907-746f2e25074d"),
                CriticalSuccess = "The GM chooses and tells you two of the following pieces of information about the enemy: which of the enemy's weaknesses is highest, which of the enemy's saving throws has the lowest modifier, one immunity the enemy has, or which of the enemy's resistances is highest. In the event of a tie, the GM should pick one at random.",
                Success = "The GM chooses one piece of information from the above list to tell you about the enemy.",
                
                CriticalFailure = "The GM gives you false information (the GM makes up the information).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d425fd4-add3-45a1-8951-df25dc999d9d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
