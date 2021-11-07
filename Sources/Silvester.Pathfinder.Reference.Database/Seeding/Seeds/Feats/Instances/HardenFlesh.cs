using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HardenFlesh : Template
    {
        public static readonly Guid ID = Guid.Parse("c59c7b05-3430-4038-b3f6-d976747d1248");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harden Flesh",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0bb8ff3d-e33e-4d63-8242-fa3684b2749a"), Type = TextBlockType.Text, Text = "You fortify your skin with minerals drawn from earth and stone. You gain resistance 3 to physical damage, except adamantine, until the beginning of your next turn. At 12th level, and every 4 levels thereafter, the resistance increases by 1, to a maximum of resistance 6 at 20th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("db8cd677-3558-4ef0-8900-18a9cd35cd13"), DruidicOrders.Instances.Stone.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d83f3e85-d904-437f-97a2-b09ccca92e73"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
