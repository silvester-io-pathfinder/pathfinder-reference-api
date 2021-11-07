using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourageousAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("8b8f5ad3-b832-4e1d-98b2-5f21dbe0c6f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courageous Assault",
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
            yield return new TextBlock { Id = Guid.Parse("db1079af-f7d6-46a6-9721-aa10802d97a7"), Type = TextBlockType.Text, Text = "With a mighty shout, you can stir an ally to attack. If your next action is to cast the (spell: inspire courage) composition cantrip, one ally who gains a status bonus from the spell can immediately use a reaction to make a melee (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("768d5f87-82f3-43e4-9ec3-12b47977a575"), Muses.Instances.Warrior.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c219cc13-3c8d-406c-8d35-5e8261c28993"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
