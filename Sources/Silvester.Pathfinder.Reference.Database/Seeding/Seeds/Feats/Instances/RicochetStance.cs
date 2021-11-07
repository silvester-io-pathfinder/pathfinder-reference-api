using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetStance : Template
    {
        public static readonly Guid ID = Guid.Parse("1ec86522-e359-4187-807b-41655fd58305");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Stance",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8d3aac6-eec9-43c0-bd68-d5db57f4fd61"), Type = TextBlockType.Text, Text = "You adopt a stance (page 150) to rebound your thrown weapons toward you. While you are in this stance, any thrown weapons you use as part of a ranged (action: Strike) to deal bludgeoning or slashing damage immediately return to your hand, enabling you to use them for additional (action: Strikes | Strike). You must be within the weapon’s listed range increment and have a hand free to catch the weapon. If you make a ranged (action: Strike) with a thrown weapon outside of its listed range increment, it instead flies back toward you a number of feet equal to its listed range increment and then falls to the ground." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0f8bab2-ba42-45fa-a483-df915a256ab8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
