using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellmastersResilience : Template
    {
        public static readonly Guid ID = Guid.Parse("21006e7c-f121-4449-939b-b13d283ab86c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellmaster's Resilience",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("556840b5-15f5-4109-8cbf-f7a3d7c4a53c"), Type = TextBlockType.Text, Text = "Your experience with a specific type of harmful magic makes you more resistant to it. Choose a magical tradition (arcane, divine, occult, or primal). You gain a +1 circumstance bonus to saving throws against spells and effects with that tradition’s trait and resistance 5 to all damage from spells and effects with that tradition’s trait. The effect must have actually been cast or created with that tradition, rather than simply being on that tradition’s spell list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8201a19d-bf54-4177-9e12-b1ab70d1fcf0"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa8af81e-dc74-4350-9c00-787e3857897b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
