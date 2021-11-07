using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemonsHair : Template
    {
        public static readonly Guid ID = Guid.Parse("c814d158-3764-4497-8b62-d007cd21ffc5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demon's Hair",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your hair already has the (trait: reach) trait, it instead gains the (trait: sweep) trait.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8b0ba49-a3bb-4e7e-8a31-18e7022dbbf3"), Type = TextBlockType.Text, Text = "Your hair constantly wriggles and writhes like that of your rival, Syu Tak-nwa. Your damage die of your hair unarmed (action: Strike) increases by one step and it gains the (trait: reach) and (trait: versatile slashing | Versatile S) traits. Your familiar assumes partial control over your hair; as long as your familiar is alive and within 30 feet, you are permanently quickened, and you can use the extra action only to make a hair (action: Strike). You can deliver hexes through your hair. When you successfully cast a non-cantrip hex that requires 2 or more actions to cast and that doesn&#39;t require a spell attack roll, if your target is within your reach, as part of the spellcasting activity you can make a hair (action: Strike) against them before applying any effects of the hex. If this (action: Strike) misses, the hex has no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5b4a537a-4ae8-4be4-bd57-b67be3ff54a2"), Feats.Instances.LivingHair.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9c73fa8-ff69-4789-a071-a534cd31f150"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
