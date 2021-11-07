using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteadySpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("afcab4f0-e58f-41b5-bf6e-1a3a339ebe87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steady Spellcasting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5e1a09b-e8fa-419e-82ac-fe8f8d695fc2"), Type = TextBlockType.Text, Text = "Confident in your technique, you don’t easily lose your concentration when you (activity: Cast a Spell). If a reaction would disrupt your spellcasting action, attempt a DC 15 flat check. If you succeed, your action isn’t disrupted." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61b83009-c201-4716-a5d3-6cd6690b4b90"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
