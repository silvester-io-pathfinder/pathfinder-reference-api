using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AmplifyingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("1b255b25-a04e-480b-9b3b-fdda3fb5f1ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Amplifying Touch",
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
            yield return new TextBlock { Id = Guid.Parse("8715a29a-c30a-4588-a3cf-f1119a3aa71d"), Type = TextBlockType.Text, Text = "Your healing energies empower attacks. An ally that recovers Hit Points from your (spell: lay on hands) gains a +1 status bonus to their attack rolls and deals 1 additional good damage on all their (action: Strikes | Strike) until the end of their next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("6af491bd-1f4c-4b07-9e26-6e2ba1d9b63a"), Spells.Instances.LayOnHands.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a5cf73c-5f17-4d91-b845-2736ac936b41"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
