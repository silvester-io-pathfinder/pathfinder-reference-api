using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildEmpathy : Template
    {
        public static readonly Guid ID = Guid.Parse("7bd4e6e2-cfdf-4318-9e31-82055957062a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wild Empathy",
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
            yield return new TextBlock { Id = Guid.Parse("f79e175b-8b11-4db3-8e4e-2072302733a7"), Type = TextBlockType.Text, Text = "You have a connection to the creatures of the natural world that allows you to communicate with them on a rudimentary level. You can use Diplomacy to (action: Make an Impression) on animals and to make very simple (action: Requests | Request) of them. In most cases, wild animals will give you time to make your case." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7e3f9e6c-bb11-4149-a214-3ec089d25a13"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("702f4437-50e5-4937-82df-9336fef9c59b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
