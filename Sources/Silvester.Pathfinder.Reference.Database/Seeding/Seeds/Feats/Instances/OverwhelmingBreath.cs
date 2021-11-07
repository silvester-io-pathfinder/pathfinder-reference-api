using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverwhelmingBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("16bddf89-9a8f-4379-a3c4-393e1a16e330");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwhelming Breath",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03cd03fe-dd8e-4621-b12d-782078d5e955"), Type = TextBlockType.Text, Text = "You control your breathing and align it with your ki, exhaling with controlled force in order to overcome your opponent’s resistance. If you use your next action to (activity: Cast a Spell) that has the (trait: monk | Monk - Item) trait and no duration, the spell and any (action: Strikes | Strike) you make as a result of casting it ignore an amount of the target’s resistance to physical damage equal to your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("eb8c6914-8993-4170-966a-84599f6d94c5"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41e45389-d287-443f-98d3-40d8e1361548"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
