using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EchoingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("ac2d8bbb-10d6-496d-b2ec-be50467175d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Echoing Spell",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de8797ee-0d42-4c65-aea8-33ca18ba709d"), Type = TextBlockType.Text, Text = "You time the components of your spell with exacting precision, setting up a resonance that duplicates the spell’s effects. If your next action is to (action: Cast a Spell) of 4th level or lower that has no duration, the spell’s energy reverberates and echoes. You can (action: Cast the Spell | Cast a Spell) a second time before the end of your next turn without expending a spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7d4ad9c8-41d0-42cb-8a88-0e9c0c937ddd"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddd6d610-1eb1-4066-a4d8-3022cd3d8433"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
