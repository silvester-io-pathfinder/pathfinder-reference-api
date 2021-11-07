using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PointBlankShot : Template
    {
        public static readonly Guid ID = Guid.Parse("aee103b3-e37e-4d19-a29e-9e21096f6f21");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Point-Blank Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9232534d-84cd-4aa1-bf0a-e8b132e0d93c"), Type = TextBlockType.Text, Text = "You take aim to pick off nearby enemies quickly. When using a ranged volley weapon while you are in this stance, you don’t take the penalty to your attack rolls from the (trait: volley) trait. When using a ranged weapon that doesn’t have the (trait: volley) trait, you gain a +2 circumstance bonus to damage rolls on attacks against targets within the weapon’s first range increment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e5fbf910-3a13-4cf4-8287-e685cfcf9471"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4181877-1231-43a1-9773-1982cd877f2b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
