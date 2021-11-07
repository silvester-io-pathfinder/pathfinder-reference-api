using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalExperimentOptionsTouchTelepathy : Template
    {
        public static readonly Guid ID = Guid.Parse("4237cffb-7f0e-4689-b0f2-fc87aad5cb6e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Experiment Options - Touch Telepathy",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6aef1c7-65bb-45f9-af8c-f23d696d7dcd"), Type = TextBlockType.Text, Text = "The experiments to your body allowed you to link minds via touch. You gain telepathy with creatures as long as you are in physical contact. This allows you to communicate mentally with any creatures you’re in physical contact with, as long as you both share a language. This doesn’t give any special access to their thoughts, and communicates no more information than normal speech would." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25a1e714-5abd-48a5-8fc1-7f5414791412"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
