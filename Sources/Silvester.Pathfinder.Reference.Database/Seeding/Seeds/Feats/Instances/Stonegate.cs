using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Stonegate : Template
    {
        public static readonly Guid ID = Guid.Parse("a9bc7f67-6113-4277-a338-03e254d980a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stonegate",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34484c0c-4f75-4135-ad75-d2579b4e65db"), Type = TextBlockType.Text, Text = "Earthen barriers no longer impede your progress. You gain (spell: passwall) as a 7th-level divine innate spell that you can cast once per day. Unlike the spell, however, this ability can be used only to open passages through barriers of earth or stone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("09f40925-5c94-415b-9439-6652176c7978"), Feats.Instances.Stonewalker.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f9e2c98-98b9-44d4-bc93-9e7b8aa4aa2c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
