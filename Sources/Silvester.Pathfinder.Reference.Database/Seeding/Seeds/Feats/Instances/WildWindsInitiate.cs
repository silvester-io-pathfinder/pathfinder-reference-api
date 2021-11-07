using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildWindsInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("c23b1422-f2c7-4b7b-ac00-2076b238259e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wild Winds Initiate",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e288f21-cb5f-4ee8-9cff-95fb0bbe42c9"), Type = TextBlockType.Text, Text = "You learn a mystical stance that lets you attack from a distance. You gain the (spell: wild winds stance) ki spell. Increase the number of Focus Points in your focus pool by 1. While entering the stance is a ki spell, the wind crash (action: Strikes | Strike) the stance grants are not, so you can use them as often as you like while in the stance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("f374863c-bd9e-40f3-a403-e53ad7540e20"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f396a099-f4fd-442d-a468-81277991cbd1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
