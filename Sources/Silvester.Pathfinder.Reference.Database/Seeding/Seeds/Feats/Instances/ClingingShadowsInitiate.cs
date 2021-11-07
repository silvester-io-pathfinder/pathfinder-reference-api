using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClingingShadowsInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("85883fd3-ffcc-4a60-85cc-1733837dd3cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clinging Shadows Initiate",
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
            yield return new TextBlock { Id = Guid.Parse("ee3dab2d-f1a8-41d2-a88d-3cf074af2ed7"), Type = TextBlockType.Text, Text = "You learn a mystical stance that transforms your ki into sticky smoke that shrouds your limbs, clinging to everything you touch. You gain the (spell: clinging shadows stance) ki spell. Increase the number of Focus Points in your focus pool by 1. While entering the stance uses a ki spell, the shadow grasp attacks it grants are not, so you can use them as often as you like while in the stance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("2c5e8332-bc2e-4fe0-bbba-e043d151142f"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8dc3961e-77dc-4349-a36a-042d1d41b38e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
