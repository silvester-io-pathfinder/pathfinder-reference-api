using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExtendArmamentAlignment : Template
    {
        public static readonly Guid ID = Guid.Parse("dfc53be5-11e0-4f4e-8d1e-630443831fbd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extend Armament Alignment",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0604c0d3-050b-4e06-aa2b-28b3e0cc1fd1"), Type = TextBlockType.Text, Text = "The alignment you impose on a weapon lasts much longer. The duration of (action: Align Armament) increases to 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a0118904-8122-4665-bd52-21efd950237d"), Feats.Instances.AlignArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ae3b78a-85bb-4551-a1ef-787936042155"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
