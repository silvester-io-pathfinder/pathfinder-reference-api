using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BiographicalEye : Template
    {
        public static readonly Guid ID = Guid.Parse("cd1b7c26-231a-418e-b0e5-b6d212d33de6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Biographical Eye",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8355775d-ddca-4a72-ad23-7e8fb8168ec1"), Type = TextBlockType.Text, Text = "In even a brief conversation or social interaction, you pick up on subtle social and visual cues to learn a great deal about a person’s origin and history. You might notice bits of green under the person’s fingernails and determine they’re an herbalist, a pin indicating their membership in a secret society, or something similar. You pick up on only details that have to do with their societal role, so you might learn the city district where a vampire lives, but wouldn’t learn any of their weaknesses, nor necessarily even that they are a vampire." };
            yield return new TextBlock { Id = Guid.Parse("4897bf17-e7b4-4043-af3b-4346cdc8f817"), Type = TextBlockType.Text, Text = "Spend 1 minute in the presence of someone you haven’t met before, or haven’t met since you first gained Biographical Eye, then attempt a DC 30 Society check. You gain a +1 circumstance bonus to the check if you engaged the person in conversation during this time. If the person is deliberately trying to conceal their nature or present a false identity, you learn about their false biography rather than their true one unless the result of your Society check exceeds their Will DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7e66424b-bfc8-4abf-b612-7e09cbb81d21"), Proficiencies.Instances.Master.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("55a523f6-e449-4666-aebb-ce2f0e48f33c"),
                CriticalSuccess = "You learn the creature’s profession, their specialty within that profession, and a major accomplishment or controversy from their career. You also learn the nation and settlement where they live, as well as the district in a city large enough to have districts. In addition, you learn the nation or settlement where they spent their formative years.",
                Success = "You learn the creature’s profession and specialty within that profession. You learn the nation or settlement where they normally live.",
                Failure = "You learn the creature’s profession and the region of the world they hail from, but no more.",
                CriticalFailure = "You learn a piece of erroneous information about the creature.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3a94af8-1989-410b-abbf-8780899589c0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
